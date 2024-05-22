namespace WebApiDbMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDataTypeForFirstName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
        }
    }
}
