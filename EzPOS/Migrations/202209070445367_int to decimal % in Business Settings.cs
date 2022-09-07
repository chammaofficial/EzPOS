namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttodecimalinBusinessSettings : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BusinessSettings", "DefaultProfitPrecentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BusinessSettings", "DefaultProfitPrecentage", c => c.Int(nullable: false));
        }
    }
}
