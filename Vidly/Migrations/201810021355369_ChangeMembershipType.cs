namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MemberShipType", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "DiscountRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "MemberShipType");
        }
    }
}
