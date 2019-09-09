namespace ChrisGiftCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TroubleShoot : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GiftGetters", "Giftee_Id", "dbo.Giftees");
            DropForeignKey("dbo.GiftGetters", "GiftEvent_Id", "dbo.GiftEvents");
            DropIndex("dbo.GiftGetters", new[] { "Giftee_Id" });
            DropIndex("dbo.GiftGetters", new[] { "GiftEvent_Id" });
            RenameColumn(table: "dbo.GiftGetters", name: "Giftee_Id", newName: "GifteeId");
            RenameColumn(table: "dbo.GiftGetters", name: "GiftEvent_Id", newName: "GiftEventId");
            AlterColumn("dbo.GiftGetters", "GifteeId", c => c.Int(nullable: false));
            AlterColumn("dbo.GiftGetters", "GiftEventId", c => c.Int(nullable: false));
            CreateIndex("dbo.GiftGetters", "GifteeId");
            CreateIndex("dbo.GiftGetters", "GiftEventId");
            AddForeignKey("dbo.GiftGetters", "GifteeId", "dbo.Giftees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GiftGetters", "GiftEventId", "dbo.GiftEvents", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GiftGetters", "GiftEventId", "dbo.GiftEvents");
            DropForeignKey("dbo.GiftGetters", "GifteeId", "dbo.Giftees");
            DropIndex("dbo.GiftGetters", new[] { "GiftEventId" });
            DropIndex("dbo.GiftGetters", new[] { "GifteeId" });
            AlterColumn("dbo.GiftGetters", "GiftEventId", c => c.Int());
            AlterColumn("dbo.GiftGetters", "GifteeId", c => c.Int());
            RenameColumn(table: "dbo.GiftGetters", name: "GiftEventId", newName: "GiftEvent_Id");
            RenameColumn(table: "dbo.GiftGetters", name: "GifteeId", newName: "Giftee_Id");
            CreateIndex("dbo.GiftGetters", "GiftEvent_Id");
            CreateIndex("dbo.GiftGetters", "Giftee_Id");
            AddForeignKey("dbo.GiftGetters", "GiftEvent_Id", "dbo.GiftEvents", "Id");
            AddForeignKey("dbo.GiftGetters", "Giftee_Id", "dbo.Giftees", "Id");
        }
    }
}
