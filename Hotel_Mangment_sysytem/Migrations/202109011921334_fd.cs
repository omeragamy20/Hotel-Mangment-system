﻿namespace HotalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
    }
}