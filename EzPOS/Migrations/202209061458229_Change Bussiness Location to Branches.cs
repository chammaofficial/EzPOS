namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBussinessLocationtoBranches : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "Address1", c => c.String());
            AddColumn("dbo.Branches", "Address2", c => c.String());
            AddColumn("dbo.Branches", "City", c => c.String());
            AddColumn("dbo.Branches", "ContactNumber", c => c.String());
            AddColumn("dbo.Branches", "EmailAddress", c => c.String());
            DropTable("dbo.BusinessLocations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BusinessLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        ContactNumber = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Branches", "EmailAddress");
            DropColumn("dbo.Branches", "ContactNumber");
            DropColumn("dbo.Branches", "City");
            DropColumn("dbo.Branches", "Address2");
            DropColumn("dbo.Branches", "Address1");
        }
    }
}
