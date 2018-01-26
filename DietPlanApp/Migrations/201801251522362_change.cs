namespace DietPlanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfiles", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.UserProfiles", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfiles", "Sex", c => c.String());
            DropColumn("dbo.UserProfiles", "Gender");
        }
    }
}
