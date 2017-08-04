namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateAddedToCustomer1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.String());
            DropColumn("dbo.Customers", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Date", c => c.String());
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
