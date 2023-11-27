namespace HealthTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Healths",
                c => new
                    {
                        HealthEntryId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Weight = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        Steps = c.Int(nullable: false),
                        SleepDuration = c.Int(nullable: false),
                        WaterIntake = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HealthEntryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Healths");
        }
    }
}
