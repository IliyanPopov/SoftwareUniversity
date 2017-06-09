namespace SoftUniAutomapperEcercises.Data
{
    using System.Data.Entity;
    using SoftUniAutomapperEcercises.Data.Migrations;
    using SoftUniAutomapperEcercises.Data.Models;


    public class DataContext : DbContext
    {
        // Your context has been configured to use a 'DataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SoftUniAutomapperEcercises.Data.DataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DataContext' 
        // connection string in the application configuration file.
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }

       // public virtual IDbSet<Employee> Employees { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().
        //        HasOptional(e => e.Manager).
        //        WithMany().
        //        HasForeignKey(m => m.ManagerId);

        //    base.OnModelCreating(modelBuilder);
        //}
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}