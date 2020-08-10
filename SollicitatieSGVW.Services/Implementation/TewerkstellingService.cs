using SollicitatieSGVW.Entity;
using SollicitatieSGVW.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Services.Implementation
{
    public class TewerkstellingService : ITewerkstellingService
    {
        private readonly ApplicationDbContext _context;
        public TewerkstellingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public  async Task CreateAsync(TewerkstellingsRecord tewerkstellingsRecord)
        {
            await _context.TewerkstellingsRecords.AddAsync(tewerkstellingsRecord);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<TewerkstellingsRecord> GetAll() => _context.TewerkstellingsRecords.OrderBy(p => p.SollicitantId);

        public TewerkstellingsRecord GetById(int id) => _context.TewerkstellingsRecords.Where(tewerkstelling => tewerkstelling.Id == id).FirstOrDefault();

    }
}
