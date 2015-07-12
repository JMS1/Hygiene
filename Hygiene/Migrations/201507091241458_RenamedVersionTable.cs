namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedVersionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckSumVersions",
                c => new
                    {
                        CheckSumVersionId = c.Int(nullable: false, identity: true),
                        CheckSum = c.String(),
                        DateChanged = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CheckSumVersionId);
            
            DropTable("dbo.Versions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Versions",
                c => new
                    {
                        VersionId = c.Int(nullable: false, identity: true),
                        CheckSum = c.String(),
                        DateChanged = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VersionId);
            
            DropTable("dbo.CheckSumVersions");
        }
    }
}
