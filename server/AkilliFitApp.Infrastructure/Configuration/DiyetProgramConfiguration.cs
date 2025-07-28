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
    internal class DiyetProgramConfiguration
    {
        public void Configure(EntityTypeBuilder<DiyetProgram> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasMany(x => x.DiyetBesinleri)
                   .WithOne(y => y.DiyetProgram)
                   .HasForeignKey(y => y.DiyetProgramId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
