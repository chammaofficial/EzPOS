namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CreateBy", c => c.String());
            AddColumn("dbo.Customers", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Customers", "UpdateBy", c => c.String());
            AddColumn("dbo.Customers", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Customers", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsActive");
            DropColumn("dbo.Customers", "UpdateDate");
            DropColumn("dbo.Customers", "UpdateBy");
            DropColumn("dbo.Customers", "CreateDate");
            DropColumn("dbo.Customers", "CreateBy");
        }
    }
}
