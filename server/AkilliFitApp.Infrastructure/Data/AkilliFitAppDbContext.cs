using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Infrastructure.Data;

namespace AkilliFitApp.Infrastructure.Data
{
    public class AkilliFitAppDbContext : DbContext
    {
        public AkilliFitAppDbContext(DbContextOptions<AkilliFitAppDbContext> options) : base(options)
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<DiyetBesin> DiyetBesinleri { get; set; }
        public DbSet<DiyetProgram> DiyetProgramlari { get; set; }
        public DbSet<KardiyoEgzersiz> KardiyoEgzersizleri { get; set; }
        public DbSet<AgirlikEgzersiz> AgirlikEgzersizleri { get; set; }
        public DbSet<KardiyoEgzersizBilgi> KardiyoEgzersizBilgileri { get; set; }
        public DbSet<AgirlikEgzersizBilgi> AgirlikEgzersizBilgileri { get; set; }
        public DbSet<EgzersizProgram> EgzersizProgramlari { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<EgzersizBilgi>()
                .UseTpcMappingStrategy();               

            modelBuilder
                .Entity<KardiyoEgzersizBilgi>()
                .ToTable("KardiyoEgzersizBilgileri");
            modelBuilder
                .Entity<AgirlikEgzersizBilgi>()
                .ToTable("AgirlikEgzersizBilgileri");

            modelBuilder.Entity<KardiyoEgzersizBilgi>()
                .HasIndex(x => new { x.EgzersizProgramId, x.KardiyoEgzersizId })
                .IsUnique();
            modelBuilder.Entity<AgirlikEgzersizBilgi>()
                .HasIndex(x => new { x.EgzersizProgramId, x.AgirlikEgzersizId })
                .IsUnique();
        }
    }
}
