namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBusinessSettingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(),
                        TransactionEditDays = c.Int(nullable: false),
                        DefaultProfitPrecentage = c.Int(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                        DateFormat = c.String(),
                        CurrencySymbolPlacement = c.String(),
                        TimeZone = c.String(),
                        TimeFormat = c.String(),
                        QtyPrecision = c.String(),
                        CurrencyPrecision = c.String(),
                        FinancialYearStartMonth = c.String(),
                        StockAccountingMethod = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .Index(t => t.CurrencyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusinessSettings", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.BusinessSettings", new[] { "CurrencyId" });
            DropTable("dbo.BusinessSettings");
        }
    }
}
