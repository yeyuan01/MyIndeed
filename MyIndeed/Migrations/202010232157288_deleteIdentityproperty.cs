namespace MyIndeed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteIdentityproperty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Jobs", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Jobs", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Jobs", "ApplicationUser_Id");
            AddForeignKey("dbo.Jobs", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
