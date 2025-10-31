using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Infrastructure.Data;

namespace SmartFitnessApp.Infrastructure.Data
{
    public class SmartFitnessAppDbContext : DbContext
    {
        public SmartFitnessAppDbContext(DbContextOptions<SmartFitnessAppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<DietFood> DietFoods { get; set; }
        public DbSet<DietProgram> DietPrograms { get; set; }
        public DbSet<CardioExercise> CardioExercises { get; set; }
        public DbSet<WeightExercise> WeightExercises { get; set; }
        public DbSet<CardioExerciseInfo> CardioExerciseInfos { get; set; }
        public DbSet<WeightExerciseInfo> WeightExerciseInfos { get; set; }
        public DbSet<ExerciseProgram> ExercisePrograms { get; set; }
        public DbSet<ExerciseNote> ExerciseNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<ExerciseInfo>()
                .UseTpcMappingStrategy();

            modelBuilder
                .Entity<CardioExerciseInfo>()
                .ToTable("CardioExerciseInfos");
            modelBuilder
                .Entity<WeightExerciseInfo>()
                .ToTable("WeightExerciseInfos");

            modelBuilder.Entity<CardioExerciseInfo>()
                .HasIndex(x => new { x.ExerciseProgramId, x.ExerciseId })
                .IsUnique();
            modelBuilder.Entity<WeightExerciseInfo>()
                .HasIndex(x => new { x.ExerciseProgramId, x.ExerciseId })
                .IsUnique();

            modelBuilder.Entity<Exercise>()
            .UseTpcMappingStrategy();

            modelBuilder.Entity<WeightExercise>()
                .ToTable("WeightExercises");

            modelBuilder.Entity<CardioExercise>()
                .ToTable("CardioExercises");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SmartFitnessAppDbContext).Assembly);

        }
    }
}
