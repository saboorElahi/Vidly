namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateAddedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Date");
        }
    }
}
