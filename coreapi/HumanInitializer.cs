using System.Data.Entity;

public class HumanInitializer : DropCreateDatabaseIfModelChanges<HumanContext> {
    protected override void Seed (HumanContext context) {
        context.Humans.AddRange (new Human[] {
            new Human { HumanName = "Juliette" },
            new Human { HumanName = "Romeo" }
        });
    }
}