namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipNameValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'PayAsYouGo' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
