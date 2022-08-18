namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductStatusCodes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductStatusCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductStatusCodes");
        }
    }
}
