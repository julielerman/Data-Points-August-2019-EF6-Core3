using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace coreapi.Controllers
{
  [Route ("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase {
        HumanContext _context;
        public HumanController (HumanContext context) {
            _context = context;

        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Human>> Get () {
            return _context.Humans.ToList ();
        }

    }
}