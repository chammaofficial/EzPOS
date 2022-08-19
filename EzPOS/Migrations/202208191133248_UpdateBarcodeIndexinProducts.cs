namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBarcodeIndexinProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "MaxOrderLevel", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "CustomBarcode", c => c.String(maxLength: 20));
            CreateIndex("dbo.Products", "CustomBarcode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "CustomBarcode" });
            DropColumn("dbo.Products", "CustomBarcode");
            DropColumn("dbo.Products", "MaxOrderLevel");
        }
    }
}
