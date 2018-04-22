namespace MaesrkLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVesselsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vessels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VesselName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vessels");
        }
    }
}
