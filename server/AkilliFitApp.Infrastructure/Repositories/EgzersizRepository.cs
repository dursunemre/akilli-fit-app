using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Infrastructure.Repositories
{
    public class EgzersizRepository : IEgzersizRepository
    {
        private readonly AkilliFitAppDbContext _context;

        public EgzersizRepository(AkilliFitAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Egzersiz>> GetAllByTipAsync(string tip)
        {
            var query = _context.Set<Egzersiz>().AsQueryable();

            if (tip.Equals("Agirlik", StringComparison.OrdinalIgnoreCase))
            {
                query = query.OfType<AgirlikEgzersiz>();
            }
            else if (tip.Equals("Kardiyo", StringComparison.OrdinalIgnoreCase))
            {
                query = query.OfType<KardiyoEgzersiz>();
            }

            return await query.ToListAsync();
        }
    }

}
