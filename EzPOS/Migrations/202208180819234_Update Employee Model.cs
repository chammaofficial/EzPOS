namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "CreateBy", c => c.String());
            AddColumn("dbo.Employees", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Employees", "UpdateBy", c => c.String());
            AddColumn("dbo.Employees", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Employees", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsActive");
            DropColumn("dbo.Employees", "UpdateDate");
            DropColumn("dbo.Employees", "UpdateBy");
            DropColumn("dbo.Employees", "CreateDate");
            DropColumn("dbo.Employees", "CreateBy");
        }
    }
}
