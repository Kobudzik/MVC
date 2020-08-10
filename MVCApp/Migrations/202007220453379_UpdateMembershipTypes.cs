namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name= 'Free' where Id=1");
        }

        public override void Down()
        {
        }
    }
}
