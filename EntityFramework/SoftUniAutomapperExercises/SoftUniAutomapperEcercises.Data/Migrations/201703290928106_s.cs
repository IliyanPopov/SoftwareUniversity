namespace SoftUniAutomapperEcercises.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employees", new[] { "Employee_Id" });
            DropColumn("dbo.Employees", "ManagerId");
            RenameColumn(table: "dbo.Employees", name: "Employee_Id", newName: "ManagerId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Employees", name: "ManagerId", newName: "Employee_Id");
            AddColumn("dbo.Employees", "ManagerId", c => c.Int());
            CreateIndex("dbo.Employees", "Employee_Id");
        }
    }
}
