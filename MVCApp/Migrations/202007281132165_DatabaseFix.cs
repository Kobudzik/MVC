namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseFix : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Movies", "Id");
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));


        }

        public override void Down()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());


        }
    }
}
