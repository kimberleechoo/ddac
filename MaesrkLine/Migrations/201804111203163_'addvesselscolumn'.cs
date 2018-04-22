namespace MaesrkLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvesselscolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vessels", "VesselDeparture", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vessels", "VesselDeparture");
        }
    }
}
