namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeBranchCodeUniqueinModel : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Branches", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Branches", new[] { "Code" });
        }
    }
}
