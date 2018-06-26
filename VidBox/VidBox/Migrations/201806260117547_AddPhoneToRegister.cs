namespace VidBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneToRegister : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
        }
    }
}
