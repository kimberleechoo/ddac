namespace MaesrkLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addextracolumnsforVessels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vessels", "DepartureFrom", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Vessels", "VesselArrival", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vessels", "ArrivingTo", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vessels", "ArrivingTo");
            DropColumn("dbo.Vessels", "VesselArrival");
            DropColumn("dbo.Vessels", "DepartureFrom");
        }
    }
}
