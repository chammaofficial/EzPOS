namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddwarrantyandunitforProductrequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropIndex("dbo.Products", new[] { "UnitId" });
            AlterColumn("dbo.Products", "UnitId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "UnitId");
            AddForeignKey("dbo.Products", "UnitId", "dbo.Units", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropIndex("dbo.Products", new[] { "UnitId" });
            AlterColumn("dbo.Products", "UnitId", c => c.Int());
            CreateIndex("dbo.Products", "UnitId");
            AddForeignKey("dbo.Products", "UnitId", "dbo.Units", "Id");
        }
    }
}
