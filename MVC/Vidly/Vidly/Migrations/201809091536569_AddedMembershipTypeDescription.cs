namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMembershipTypeDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "MemberShipType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "MemberShipType");
        }
    }
}
