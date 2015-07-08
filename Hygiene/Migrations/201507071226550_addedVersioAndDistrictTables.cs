namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedVersioAndDistrictTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DistrictId);
            
            CreateTable(
                "dbo.Versions",
                c => new
                    {
                        VersionId = c.Int(nullable: false, identity: true),
                        CheckSum = c.String(),
                    })
                .PrimaryKey(t => t.VersionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Versions");
            DropTable("dbo.Districts");
        }
    }
}
