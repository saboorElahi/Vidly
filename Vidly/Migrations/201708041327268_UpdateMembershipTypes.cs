namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'Pay as you go' where Id = 1");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Monthly' where Id = 2");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Quaterly' where Id = 3");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Anual' where Id = 4");
        }

        public override void Down()
        {
        }
    }
}
