namespace MyIndeed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPostUserToJob : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "PostUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Jobs", "PostUser_Id");
            AddForeignKey("dbo.Jobs", "PostUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "PostUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Jobs", new[] { "PostUser_Id" });
            DropColumn("dbo.Jobs", "PostUser_Id");
        }
    }
}
