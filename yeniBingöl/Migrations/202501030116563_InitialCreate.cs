namespace yeniBingöl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilcelers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IlceAd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NufusBilgis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YearID = c.Int(nullable: false),
                        PopulationYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NufusBilgis");
            DropTable("dbo.Ilcelers");
        }
    }
}
