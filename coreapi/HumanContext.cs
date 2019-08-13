using System.Data.Entity;

public class HumanContext : DbContext {
    public HumanContext (string connectionString) : base (connectionString) {
        Database.SetInitializer<HumanContext> (new HumanInitializer ());
    }

    //public HumanContext () { }

    public DbSet<Human> Humans { get; set; }
    protected override void OnModelCreating (DbModelBuilder modelBuilder) {
        modelBuilder.Entity<Human> ().ToTable ("Humans");
    }

}
