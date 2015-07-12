namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedVersionIdFromRestaurantTableAddedCheckSumVersionToDistrictTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Districts", "CheckSumVersionId", c => c.Int());
            DropColumn("dbo.Restaurants", "VersionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "VersionId", c => c.Int());
            DropColumn("dbo.Districts", "CheckSumVersionId");
        }
    }
}
