namespace MyIndeed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addJobIdToUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id1", "dbo.AspNetUsers");
            DropIndex("dbo.Jobs", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Jobs", new[] { "ApplicationUser_Id1" });
            DropColumn("dbo.Jobs", "ApplicationUser_Id");
            DropColumn("dbo.Jobs", "ApplicationUser_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "ApplicationUser_Id1", c => c.String(maxLength: 128));
            AddColumn("dbo.Jobs", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Jobs", "ApplicationUser_Id1");
            CreateIndex("dbo.Jobs", "ApplicationUser_Id");
            AddForeignKey("dbo.Jobs", "ApplicationUser_Id1", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Jobs", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
