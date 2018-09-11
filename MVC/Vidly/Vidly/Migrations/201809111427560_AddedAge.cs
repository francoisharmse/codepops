namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "age");
        }
    }
}
