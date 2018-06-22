namespace VidBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Animated')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Science Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
