namespace DietPlanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedpasswordformUserProfile : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfiles", "Password");
            DropColumn("dbo.UserProfiles", "VerifyPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfiles", "VerifyPassword", c => c.String());
            AddColumn("dbo.UserProfiles", "Password", c => c.String());
        }
    }
}
