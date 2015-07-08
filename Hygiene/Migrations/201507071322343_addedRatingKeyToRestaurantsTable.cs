namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRatingKeyToRestaurantsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "RatingKey", c => c.String());
            DropColumn("dbo.Restaurants", "HygieneScore");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "HygieneScore", c => c.Int());
            DropColumn("dbo.Restaurants", "RatingKey");
        }
    }
}
