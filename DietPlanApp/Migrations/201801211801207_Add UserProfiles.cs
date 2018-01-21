namespace DietPlanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserProfiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserProfileId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Name = c.String(),
                        Surname = c.String(),
                        MailAdress = c.String(),
                        Password = c.String(),
                        VeryfiyPassword = c.String(),
                        Sex = c.String(),
                        Age = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        PhysicalActivity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserProfileId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfiles", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserProfiles", new[] { "UserId" });
            DropTable("dbo.UserProfiles");
        }
    }
}
