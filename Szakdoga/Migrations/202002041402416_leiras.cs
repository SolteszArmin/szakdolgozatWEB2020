﻿namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class leiras : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Leiras", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Leiras");
        }
    }
}
