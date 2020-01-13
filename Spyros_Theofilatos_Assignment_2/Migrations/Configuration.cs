namespace Spyros_Theofilatos_Assignment_2.Migrations
{
    using Spyros_Theofilatos_Assignment_2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrainerMananagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrainerMananagerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            //Kanw populate tin basi me kapoia arika records wste sto uppdate database na gemisei i basi 
            context.Trainers.AddOrUpdate(t => new { t.Firstname, t.Lastname, t.Subject },
                        new Trainer { Firstname = "Freddy", Lastname = "Mercury", Subject = "Music" },
                        new Trainer { Firstname = "Anakin", Lastname = "Skywalker", Subject = "Anger Management" },
                        new Trainer { Firstname = "Darth", Lastname = "Vader", Subject = "Anger Management 2" }

                        );
        }
    }
}
