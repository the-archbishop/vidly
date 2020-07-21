namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Science Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Historical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Documentary')");
        }
        
        public override void Down()
        {
        }
    }
}
