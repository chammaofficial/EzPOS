namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogotoBusinessSettings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusinessSettings", "Logo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BusinessSettings", "Logo");
        }
    }
}
