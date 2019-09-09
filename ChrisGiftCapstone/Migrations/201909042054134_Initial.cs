namespace ChrisGiftCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Spending = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Giftees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        TypeOfRelationshipId = c.Int(nullable: false),
                        LengthOfRelationshipId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.LengthOfRelationships", t => t.LengthOfRelationshipId, cascadeDelete: true)
                .ForeignKey("dbo.TypeOfRelationships", t => t.TypeOfRelationshipId, cascadeDelete: true)
                .Index(t => t.TypeOfRelationshipId)
                .Index(t => t.LengthOfRelationshipId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.LengthOfRelationships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeOfRelationships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Relationship = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GiftEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GiftGetters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        HobbiesInterest = c.String(),
                        GifteeId = c.Int(nullable: false),
                        GiftEventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Giftees", t => t.GifteeId, cascadeDelete: true)
                .ForeignKey("dbo.GiftEvents", t => t.GiftEventId, cascadeDelete: true)
                .Index(t => t.GifteeId)
                .Index(t => t.GiftEventId);
            
            CreateTable(
                "dbo.Gifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        ProductDetails = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Subcategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Subcategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.GiftGetters", "GiftEventId", "dbo.GiftEvents");
            DropForeignKey("dbo.GiftGetters", "GifteeId", "dbo.Giftees");
            DropForeignKey("dbo.Giftees", "TypeOfRelationshipId", "dbo.TypeOfRelationships");
            DropForeignKey("dbo.Giftees", "LengthOfRelationshipId", "dbo.LengthOfRelationships");
            DropForeignKey("dbo.Giftees", "CategoryId", "dbo.Categories");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Subcategories", new[] { "CategoryId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.GiftGetters", new[] { "GiftEventId" });
            DropIndex("dbo.GiftGetters", new[] { "GifteeId" });
            DropIndex("dbo.Giftees", new[] { "CategoryId" });
            DropIndex("dbo.Giftees", new[] { "LengthOfRelationshipId" });
            DropIndex("dbo.Giftees", new[] { "TypeOfRelationshipId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Subcategories");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Gifts");
            DropTable("dbo.GiftGetters");
            DropTable("dbo.GiftEvents");
            DropTable("dbo.TypeOfRelationships");
            DropTable("dbo.LengthOfRelationships");
            DropTable("dbo.Giftees");
            DropTable("dbo.Categories");
            DropTable("dbo.Budgets");
        }
    }
}
