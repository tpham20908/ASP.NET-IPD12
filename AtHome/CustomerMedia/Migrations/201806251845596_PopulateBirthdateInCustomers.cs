namespace CustomerMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdateInCustomers : DbMigration
    {
        public override void Up()
        {
            Sql(@"UPDATE Customers SET Birthdate = '1985-9-10' WHERE Id = 2");
            Sql(@"UPDATE Customers SET Birthdate = '1976-7-12' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
