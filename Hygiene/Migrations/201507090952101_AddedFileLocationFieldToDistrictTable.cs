namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFileLocationFieldToDistrictTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Districts", "FileLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Districts", "FileLocation");
        }
    }
}
