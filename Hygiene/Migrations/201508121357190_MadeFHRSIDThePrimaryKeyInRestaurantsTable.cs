namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeFHRSIDThePrimaryKeyInRestaurantsTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Restaurants");
            AlterColumn("dbo.Restaurants", "FHRSID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Restaurants", "FHRSID");
            DropColumn("dbo.Restaurants", "RestaurantId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "RestaurantId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Restaurants");
            AlterColumn("dbo.Restaurants", "FHRSID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Restaurants", "RestaurantId");
        }
    }
}
