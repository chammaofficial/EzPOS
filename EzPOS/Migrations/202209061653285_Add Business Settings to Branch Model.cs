namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBusinessSettingstoBranchModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "BusinessSettingId", c => c.Int());
            CreateIndex("dbo.Branches", "BusinessSettingId");
            AddForeignKey("dbo.Branches", "BusinessSettingId", "dbo.BusinessSettings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "BusinessSettingId", "dbo.BusinessSettings");
            DropIndex("dbo.Branches", new[] { "BusinessSettingId" });
            DropColumn("dbo.Branches", "BusinessSettingId");
        }
    }
}
