namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthDatetoOneClient : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-12-21' AS DATETIME)  WHERE Id = 1");
        }

        public override void Down()
        {
        }
    }
}
