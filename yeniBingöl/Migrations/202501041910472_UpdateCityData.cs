namespace yeniBingöl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCityData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NufusBilgis", "YearID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NufusBilgis", "YearID", c => c.Int(nullable: false));
        }
    }
}
