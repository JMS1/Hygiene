namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCheckSumStringAndDateChangedToDistrictTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Districts", "CheckSum", c => c.String());
            AddColumn("dbo.Districts", "CheckSumChanged", c => c.DateTime(nullable: false));
            DropColumn("dbo.Districts", "CheckSumVersionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Districts", "CheckSumVersionId", c => c.Int());
            DropColumn("dbo.Districts", "CheckSumChanged");
            DropColumn("dbo.Districts", "CheckSum");
        }
    }
}
