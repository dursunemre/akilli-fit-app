using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Domain.Entities
{
    public abstract class Exercise
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
