namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddwarrantyandunitforProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitId", c => c.Int());
            AddColumn("dbo.Products", "HasWarranty", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Products", "UnitId");
            AddForeignKey("dbo.Products", "UnitId", "dbo.Units", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropIndex("dbo.Products", new[] { "UnitId" });
            DropColumn("dbo.Products", "HasWarranty");
            DropColumn("dbo.Products", "UnitId");
        }
    }
}
