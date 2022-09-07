namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPrecisionfromBusinessSettings : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BusinessSettings", "QtyPrecision");
            DropColumn("dbo.BusinessSettings", "CurrencyPrecision");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusinessSettings", "CurrencyPrecision", c => c.Int(nullable: false));
            AddColumn("dbo.BusinessSettings", "QtyPrecision", c => c.Int(nullable: false));
        }
    }
}
