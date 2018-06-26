namespace VidBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte());
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());

            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
