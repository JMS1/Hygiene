namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDatabaseGeneratedAttributeToFHRSID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Restaurants");
            AlterColumn("dbo.Restaurants", "FHRSID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Restaurants", "FHRSID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Restaurants");
            AlterColumn("dbo.Restaurants", "FHRSID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Restaurants", "FHRSID");
        }
    }
}
