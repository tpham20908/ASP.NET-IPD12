namespace CustomerMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembership : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Memberships(SignupFee, DurationInMonth, DiscountRate) VALUES(0, 0, 0)");
            Sql(@"INSERT INTO Memberships(SignupFee, DurationInMonth, DiscountRate) VALUES(10, 1, 10)");
            Sql(@"INSERT INTO Memberships(SignupFee, DurationInMonth, DiscountRate) VALUES(20, 3, 15)");
            Sql(@"INSERT INTO Memberships(SignupFee, DurationInMonth, DiscountRate) VALUES(30, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
