namespace EzPOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCurrencies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('Sri Lankan Rupees','LKR')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('US Dollars','USD')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('Singapore Dollars','SGD')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('Australian Dollars','AUD')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('Indian Rupees','INR')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('British Pound','GBP')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('European Euro','EUR')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('Japanese Yen','JPY')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('Canadian Dollar','CAD')");
            Sql("INSERT into Currencies(Name,Symbol) VALUES ('UAE Dirahm','AED')");
        }
        
        public override void Down()
        {
        }
    }
}
