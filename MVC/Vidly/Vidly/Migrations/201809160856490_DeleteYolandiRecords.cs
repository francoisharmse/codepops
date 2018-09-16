namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteYolandiRecords : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Customers WHERE name like '%yolandi%'");
        }
        
        public override void Down()
        {
        }
    }
}
