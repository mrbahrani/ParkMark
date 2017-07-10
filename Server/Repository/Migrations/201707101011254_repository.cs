namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repository : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkingPlaces",
                c => new
                    {
                        ParkingPlaceID = c.Int(nullable: false, identity: true),
                        X_Position = c.Int(nullable: false),
                        Y_Position = c.Int(nullable: false),
                        UserInfoRefID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParkingPlaceID)
                .ForeignKey("dbo.UserInfoes", t => t.UserInfoRefID, cascadeDelete: true)
                .Index(t => t.UserInfoRefID);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        UserInfoID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        FamilyName = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                        Plate = c.String(),
                        Credit = c.Int(nullable: false),
                        Authorisation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserInfoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkingPlaces", "UserInfoRefID", "dbo.UserInfoes");
            DropIndex("dbo.ParkingPlaces", new[] { "UserInfoRefID" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.ParkingPlaces");
        }
    }
}
