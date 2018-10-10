namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock ) VALUES(1, 'Mission: Impossible – Fallout', 1, 12/08/2018, 12/08/2018, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
