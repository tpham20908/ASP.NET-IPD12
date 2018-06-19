namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypes2 : DbMigration
    {
        public override void Up()
        {
            // pushing update to database
            // pay as you go
            Sql(
                "INSERT into Memberships(Id, SignupFee, DurationInMonths, DiscountRate) " +
                "VALUES(1, 0, 0, 0)");
            // monthly
            Sql(
                "INSERT into Memberships(Id, SignupFee, DurationInMonths, DiscountRate) " +
                "VALUES(2, 10, 1, 10)");
            // quarterly
            Sql(
                "INSERT into Memberships(Id, SignupFee, DurationInMonths, DiscountRate) " +
                "VALUES(3, 30, 3, 15)");
            // annual
            Sql(
                "INSERT into Memberships(Id, SignupFee, DurationInMonths, DiscountRate) " +
                "VALUES(4, 50, 12, 30)");
        }

        public override void Down()
        {
        }
    }
}
