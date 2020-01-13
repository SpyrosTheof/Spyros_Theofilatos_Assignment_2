namespace Spyros_Theofilatos_Assignment_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetConstraintsToTrainersTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainers", "Firstname", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Trainers", "Lastname", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Trainers", "Subject", c => c.String(nullable: false, maxLength: 450));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainers", "Subject", c => c.String());
            AlterColumn("dbo.Trainers", "Lastname", c => c.String());
            AlterColumn("dbo.Trainers", "Firstname", c => c.String());
        }
    }
}
