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
    internal class EgzersizProgramConfig
    {
        public void Configure(EntityTypeBuilder<EgzersizProgram> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasMany(x => x.EgzersizBilgi)
                   .WithOne(y => y.EgzersizProgram)
                   .HasForeignKey(y => y.EgzersizProgramId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
