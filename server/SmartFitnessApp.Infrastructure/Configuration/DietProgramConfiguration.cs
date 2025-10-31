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
    internal class DietProgramConfiguration
    {
        public void Configure(EntityTypeBuilder<DietProgram> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasMany(x => x.DietFoods)
                   .WithOne(y => y.DietProgram)
                   .HasForeignKey(y => y.DietProgramId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
