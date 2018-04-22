namespace MaesrkLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBookingTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "ContainerSize", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bookings", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Bookings", "VesselName", c => c.String());
            DropColumn("dbo.Bookings", "ContainerWeight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "ContainerWeight", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bookings", "VesselName", c => c.Int(nullable: false));
            AlterColumn("dbo.Bookings", "PhoneNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Bookings", "ContainerSize");
        }
    }
}
