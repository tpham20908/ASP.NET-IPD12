namespace CustomerMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAddressInCustomers : DbMigration
    {
        public override void Up()
        {
            Sql(@"UPDATE Customers SET Address = '123 Mackay, Ottawa' WHERE Id = 1");
            Sql(@"UPDATE Customers SET Address = '5566 St.Catherine, Quebec' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
