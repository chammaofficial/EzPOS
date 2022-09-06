namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBusinessSettingstoBranchModelRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Branches", "BusinessSettingId", "dbo.BusinessSettings");
            DropIndex("dbo.Branches", new[] { "BusinessSettingId" });
            AlterColumn("dbo.Branches", "BusinessSettingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Branches", "BusinessSettingId");
            AddForeignKey("dbo.Branches", "BusinessSettingId", "dbo.BusinessSettings", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "BusinessSettingId", "dbo.BusinessSettings");
            DropIndex("dbo.Branches", new[] { "BusinessSettingId" });
            AlterColumn("dbo.Branches", "BusinessSettingId", c => c.Int());
            CreateIndex("dbo.Branches", "BusinessSettingId");
            AddForeignKey("dbo.Branches", "BusinessSettingId", "dbo.BusinessSettings", "Id");
        }
    }
}
