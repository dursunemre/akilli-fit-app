using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IService
{
    public interface IExerciseService
    {
        Task<IEnumerable<Exercise>> GetAllByTypeAsync(string type);
    }

}
