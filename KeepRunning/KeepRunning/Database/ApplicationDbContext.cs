using KeepRunning.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KeepRunning.Database
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Runner> Runners { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<Training> Trainings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Runner>()
                .HasMany<TrainingPlan>(runner => runner.TrainingPlans)
                .WithOne(trainingPlan => trainingPlan.Runner);

            modelBuilder.Entity<TrainingPlan>()
                .HasMany<Training>(tp => tp.Trainings)
                .WithOne(training => training.TrainingPlan);
        }
    }
}
