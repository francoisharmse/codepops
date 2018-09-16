namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedAgePropertyFromCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "age", c => c.Int(nullable: false));
        }
    }
}
