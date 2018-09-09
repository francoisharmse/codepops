namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeDescription : DbMigration
    {
        public override void Up()
        {
            Sql("update MemberShipTypes set MemberShipTypeName = 'Pay As You Go' where DurationMonths = 0");
            Sql("update MemberShipTypes set MemberShipTypeName = 'Monthly' where DurationMonths = 1");
            Sql("update MemberShipTypes set MemberShipTypeName = 'Quarterly' where DurationMonths = 3");
            Sql("update MemberShipTypes set MemberShipTypeName = 'Yearly' where DurationMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
