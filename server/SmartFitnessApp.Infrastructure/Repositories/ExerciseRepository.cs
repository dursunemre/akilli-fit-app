using SmartFitnessApp.Application.Interfaces.IRepository;
using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Infrastructure.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly SmartFitnessAppDbContext _context;

        public ExerciseRepository(SmartFitnessAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Exercise>> GetAllByTypeAsync(string type)
        {
            var query = _context.Set<Exercise>().AsQueryable();

            if (type.Equals("Weight", StringComparison.OrdinalIgnoreCase))
            {
                query = query.OfType<WeightExercise>();
            }
            else if (type.Equals("Cardio", StringComparison.OrdinalIgnoreCase))
            {
                query = query.OfType<CardioExercise>();
            }

            return await query.ToListAsync();
        }
    }

}
