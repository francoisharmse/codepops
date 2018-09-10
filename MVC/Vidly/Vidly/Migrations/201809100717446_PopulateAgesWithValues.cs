namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAgesWithValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Age = 100");
        }
        
        public override void Down()
        {
        }
    }
}
