namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBranchestoUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBranches",
                c => new
                    {
                        User_Username = c.String(nullable: false, maxLength: 20),
                        Branch_Code = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => new { t.User_Username, t.Branch_Code })
                .ForeignKey("dbo.Users", t => t.User_Username, cascadeDelete: true)
                .ForeignKey("dbo.Branches", t => t.Branch_Code, cascadeDelete: true)
                .Index(t => t.User_Username)
                .Index(t => t.Branch_Code);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBranches", "Branch_Code", "dbo.Branches");
            DropForeignKey("dbo.UserBranches", "User_Username", "dbo.Users");
            DropIndex("dbo.UserBranches", new[] { "Branch_Code" });
            DropIndex("dbo.UserBranches", new[] { "User_Username" });
            DropTable("dbo.UserBranches");
        }
    }
}
