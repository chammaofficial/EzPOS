namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSupplierModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "CreateBy", c => c.String());
            AddColumn("dbo.Suppliers", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Suppliers", "UpdateBy", c => c.String());
            AddColumn("dbo.Suppliers", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Suppliers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Suppliers", "Other", c => c.String());
            AddColumn("dbo.Suppliers", "Remark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "Remark");
            DropColumn("dbo.Suppliers", "Other");
            DropColumn("dbo.Suppliers", "IsActive");
            DropColumn("dbo.Suppliers", "UpdateDate");
            DropColumn("dbo.Suppliers", "UpdateBy");
            DropColumn("dbo.Suppliers", "CreateDate");
            DropColumn("dbo.Suppliers", "CreateBy");
        }
    }
}
