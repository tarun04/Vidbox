namespace VidBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate)" +
                                    "VALUES (1, 'Pay As You Go', 0, 0 , 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate)" +
                                    "VALUES (2, 'Monthly', 10, 1 , 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate)" +
                                    "VALUES (3, 'Quarterly', 50, 6 , 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate)" +
                                    "VALUES (4, 'Annualy', 100, 12 , 25)");
        }
        
        public override void Down()
        {
        }
    }
}
