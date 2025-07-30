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
    internal class EgzersizBilgiConfiguration
    {
        public void Configure(EntityTypeBuilder<EgzersizBilgi> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasOne(x => x.EgzersizNot)
                   .WithOne(y => y.EgzersizBilgi)
                   .HasForeignKey<EgzersizNot>(y => y.EgzersizBilgiId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
