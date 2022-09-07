namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimestampstoUnits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "CreateBy", c => c.String());
            AddColumn("dbo.Units", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Units", "UpdateBy", c => c.String());
            AddColumn("dbo.Units", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Units", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Units", "Symbol", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Units", "Symbol", c => c.String());
            AlterColumn("dbo.Units", "Name", c => c.String());
            DropColumn("dbo.Units", "UpdateDate");
            DropColumn("dbo.Units", "UpdateBy");
            DropColumn("dbo.Units", "CreateDate");
            DropColumn("dbo.Units", "CreateBy");
        }
    }
}
