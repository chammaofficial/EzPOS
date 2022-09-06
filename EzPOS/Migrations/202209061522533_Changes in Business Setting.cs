namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesinBusinessSetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusinessSettings", "StartDate", c => c.DateTime());
            AlterColumn("dbo.BusinessSettings", "QtyPrecision", c => c.Int(nullable: false));
            AlterColumn("dbo.BusinessSettings", "CurrencyPrecision", c => c.Int(nullable: false));
            AlterColumn("dbo.BusinessSettings", "FinancialYearStartMonth", c => c.Int(nullable: false));
            DropColumn("dbo.BusinessSettings", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusinessSettings", "DateTime", c => c.DateTime());
            AlterColumn("dbo.BusinessSettings", "FinancialYearStartMonth", c => c.String());
            AlterColumn("dbo.BusinessSettings", "CurrencyPrecision", c => c.String());
            AlterColumn("dbo.BusinessSettings", "QtyPrecision", c => c.String());
            DropColumn("dbo.BusinessSettings", "StartDate");
        }
    }
}
