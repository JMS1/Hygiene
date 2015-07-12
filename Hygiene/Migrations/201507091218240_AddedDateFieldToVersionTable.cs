namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateFieldToVersionTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Versions", "DateChanged", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Versions", "DateChanged");
        }
    }
}
