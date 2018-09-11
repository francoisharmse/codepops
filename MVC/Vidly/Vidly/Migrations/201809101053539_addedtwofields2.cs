namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtwofields2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Age");
            DropColumn("dbo.Customers", "spousename");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "spousename", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Customers", "Age", c => c.Int(nullable: false));
        }
    }
}
