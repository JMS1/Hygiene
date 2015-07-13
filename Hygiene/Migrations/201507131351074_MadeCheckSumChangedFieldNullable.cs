namespace Hygiene.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeCheckSumChangedFieldNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Districts", "CheckSumChanged", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Districts", "CheckSumChanged", c => c.DateTime(nullable: false));
        }
    }
}
