namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'Action')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'Thriller')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'Family')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'Romance')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,'Comedy')");

            Sql("INSERT INTO Movies (GenreId,Name,NumberInStock,DateAdded,ReleaseDate) VALUES (1,'Die Hard',3,CAST('2020-07-22' AS DATETIME),CAST('2005-03-12' AS DATETIME) )");
            Sql("INSERT INTO Movies (GenreId,Name,NumberInStock,DateAdded,ReleaseDate) VALUES (4,'Romeo and Julia',19,CAST('2020-07-22' AS DATETIME),CAST('1992-03-12' AS DATETIME) )");
            Sql("INSERT INTO Movies (GenreId,Name,NumberInStock,DateAdded,ReleaseDate) VALUES (5,'Funny Boi', 1,CAST('2020-07-22' AS DATETIME),CAST('2001-01-14' AS DATETIME) )");
        }
        
        public override void Down()
        {
        }
    }
}
