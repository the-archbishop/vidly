namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthdates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-05-25' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
