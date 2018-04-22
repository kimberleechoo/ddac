namespace MaesrkLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBookingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        CustomerEmail = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.Int(nullable: false),
                        ContainerType = c.String(nullable: false, maxLength: 50),
                        ContainerWeight = c.String(nullable: false, maxLength: 50),
                        VesselName = c.Int(nullable: false),
                        VesselsInformation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vessels", t => t.VesselsInformation_ID)
                .Index(t => t.VesselsInformation_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "VesselsInformation_ID", "dbo.Vessels");
            DropIndex("dbo.Bookings", new[] { "VesselsInformation_ID" });
            DropTable("dbo.Bookings");
        }
    }
}
