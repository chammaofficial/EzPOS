namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNametoBusinessSettings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusinessSettings", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BusinessSettings", "Name");
        }
    }
}
