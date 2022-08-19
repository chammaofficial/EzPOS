namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductStatusCodes", "CreateBy", c => c.String());
            AddColumn("dbo.ProductStatusCodes", "CreateDate", c => c.DateTime());
            AddColumn("dbo.ProductStatusCodes", "UpdateBy", c => c.String());
            AddColumn("dbo.ProductStatusCodes", "UpdateDate", c => c.DateTime());
            CreateIndex("dbo.ProductStatusCodes", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductStatusCodes", new[] { "Name" });
            DropColumn("dbo.ProductStatusCodes", "UpdateDate");
            DropColumn("dbo.ProductStatusCodes", "UpdateBy");
            DropColumn("dbo.ProductStatusCodes", "CreateDate");
            DropColumn("dbo.ProductStatusCodes", "CreateBy");
        }
    }
}
