namespace CustomerMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipId) VALUES('Juntin Trudeau', 1, 2)");
            Sql(@"INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipId) VALUES('Phillip Couillard', 0, 1)");
            Sql(@"INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipId) VALUES('Valerie Plant', 1, 3)");
            Sql(@"INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipId) VALUES('Donald Trump', 1, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
