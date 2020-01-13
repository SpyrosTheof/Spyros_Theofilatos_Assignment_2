namespace Spyros_Theofilatos_Assignment_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTrainersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Subject = c.String(),
                    })
                .PrimaryKey(t => t.TrainerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainers");
        }
    }
}
