namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTimezoneandFormatFromBusinessSettings : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BusinessSettings", "TimeZone");
            DropColumn("dbo.BusinessSettings", "TimeFormat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusinessSettings", "TimeFormat", c => c.String());
            AddColumn("dbo.BusinessSettings", "TimeZone", c => c.String());
        }
    }
}
