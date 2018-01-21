namespace DietPlanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Typofixes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfiles", "MailAddress", c => c.String());
            AddColumn("dbo.UserProfiles", "VerifyPassword", c => c.String());
            DropColumn("dbo.UserProfiles", "MailAdress");
            DropColumn("dbo.UserProfiles", "VeryfiyPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfiles", "VeryfiyPassword", c => c.String());
            AddColumn("dbo.UserProfiles", "MailAdress", c => c.String());
            DropColumn("dbo.UserProfiles", "VerifyPassword");
            DropColumn("dbo.UserProfiles", "MailAddress");
        }
    }
}
