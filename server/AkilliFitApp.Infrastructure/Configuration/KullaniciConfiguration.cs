using AkilliFitApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Infrastructure.Configuration
{
    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasMany(u => u.EgzersizProgramlar)
               .WithOne(p => p.Kullanici)
               .HasForeignKey(p => p.KullaniciId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.DiyetProgramlar)
                   .WithOne(dp => dp.Kullanici)
                   .HasForeignKey(dp => dp.KullaniciId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
