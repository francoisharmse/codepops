namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationMonths, Discount) VALUES (1,0,0,0)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationMonths, Discount) VALUES (2,30,1,10)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationMonths, Discount) VALUES (3,90,3,15)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationMonths, Discount) VALUES (4,30,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
