namespace MyIndeed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addJobIdToUser3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AppliedJobs", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "PostedJobs", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PostedJobs");
            DropColumn("dbo.AspNetUsers", "AppliedJobs");
        }
    }
}
