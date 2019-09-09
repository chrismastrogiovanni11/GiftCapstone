namespace ChrisGiftCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class push : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiftEvents", "EventDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GiftEvents", "EventDate");
        }
    }
}
