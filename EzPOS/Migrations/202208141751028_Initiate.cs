namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initiate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 5),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        Address = c.String(nullable: false, maxLength: 1000),
                        Mobile = c.String(nullable: false, maxLength: 10),
                        Nic = c.String(nullable: false, maxLength: 12),
                        Email = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        Address = c.String(nullable: false, maxLength: 1000),
                        Mobile = c.String(nullable: false, maxLength: 10),
                        Nic = c.String(nullable: false, maxLength: 12),
                        Email = c.String(maxLength: 500),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        Address = c.String(nullable: false, maxLength: 1000),
                        Phone = c.String(nullable: false, maxLength: 10),
                        ContactPerson = c.String(nullable: false, maxLength: 500),
                        Mobile = c.String(nullable: false, maxLength: 10),
                        Email = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserBranches",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Branch_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Branch_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Branches", t => t.Branch_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Branch_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.UserBranches", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.UserBranches", "User_Id", "dbo.Users");
            DropIndex("dbo.UserBranches", new[] { "Branch_Id" });
            DropIndex("dbo.UserBranches", new[] { "User_Id" });
            DropIndex("dbo.Employees", new[] { "BranchId" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropTable("dbo.UserBranches");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Users");
            DropTable("dbo.Branches");
        }
    }
}
