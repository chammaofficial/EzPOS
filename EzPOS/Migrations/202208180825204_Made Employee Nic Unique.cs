namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeEmployeeNicUnique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Employees", "Nic", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "Nic" });
        }
    }
}
