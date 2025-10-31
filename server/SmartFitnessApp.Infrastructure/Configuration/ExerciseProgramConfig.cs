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
    internal class ExerciseProgramConfig
    {
        public void Configure(EntityTypeBuilder<ExerciseProgram> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasMany(x => x.ExerciseInfos)
                   .WithOne(y => y.ExerciseProgram)
                   .HasForeignKey(y => y.ExerciseProgramId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
