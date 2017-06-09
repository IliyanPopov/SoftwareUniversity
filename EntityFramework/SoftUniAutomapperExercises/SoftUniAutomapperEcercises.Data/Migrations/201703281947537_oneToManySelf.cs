namespace SoftUniAutomapperEcercises.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oneToManySelf : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Employees", "Employee_Id", c => c.Int());
            //CreateIndex("dbo.Employees", "Employee_Id");
            //AddForeignKey("dbo.Employees", "Employee_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Employees", "Employee_Id", "dbo.Employees");
            //DropIndex("dbo.Employees", new[] { "Employee_Id" });
            //DropColumn("dbo.Employees", "Employee_Id");
        }
    }
}
