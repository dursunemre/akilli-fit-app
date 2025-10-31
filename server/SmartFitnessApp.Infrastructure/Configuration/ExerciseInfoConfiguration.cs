using SmartFitnessApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Infrastructure.Configuration
{
    internal class ExerciseInfoConfiguration
    {
        public void Configure(EntityTypeBuilder<ExerciseInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasOne(x => x.ExerciseNote)
                   .WithOne(y => y.ExerciseInfo)
                   .HasForeignKey<ExerciseNote>(y => y.ExerciseInfoId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
