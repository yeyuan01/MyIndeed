namespace MyIndeed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addappliedandpostedJobstouser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Jobs", "ApplicationUser_Id1", c => c.String(maxLength: 128));
            CreateIndex("dbo.Jobs", "ApplicationUser_Id");
            CreateIndex("dbo.Jobs", "ApplicationUser_Id1");
            AddForeignKey("dbo.Jobs", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Jobs", "ApplicationUser_Id1", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Jobs", new[] { "ApplicationUser_Id1" });
            DropIndex("dbo.Jobs", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Jobs", "ApplicationUser_Id1");
            DropColumn("dbo.Jobs", "ApplicationUser_Id");
        }
    }
}
