using Spyros_Theofilatos_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class TrainerMananagerContext : DbContext
{
  
    public TrainerMananagerContext() : base("name=TrainerMananagerContext")
    {
    }

    public DbSet<Trainer> Trainers { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Trainer>()
                    .Property(t => t.Firstname)
                    .IsRequired()
                    .HasMaxLength(450);           

        modelBuilder.Entity<Trainer>()
                  .Property(t => t.Lastname)
                  .IsRequired()
                  .HasMaxLength(450);

        modelBuilder.Entity<Trainer>()
               .Property(t => t.Subject)
               .IsRequired()
               .HasMaxLength(450);



        base.OnModelCreating(modelBuilder);

    }
}
