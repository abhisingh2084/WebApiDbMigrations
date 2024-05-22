﻿namespace WebApiDbMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppliedDataAnnotationOnFNandGender : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Employees", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Gender", c => c.String());
            AlterColumn("dbo.Employees", "FirstName", c => c.String(maxLength: 8000, unicode: false));
        }
    }
}
