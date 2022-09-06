namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActivestatustoBranch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Branches", "IsActive");
        }
    }
}
