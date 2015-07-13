namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCheckSumTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CheckSumVersions");
        }
        
        public override void Down()
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
            
        }
    }
}
