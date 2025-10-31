using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IRepository
{
    public interface IExerciseRepository
    {
        Task<IEnumerable<Exercise>> GetAllByTypeAsync(string type);
    }

}
