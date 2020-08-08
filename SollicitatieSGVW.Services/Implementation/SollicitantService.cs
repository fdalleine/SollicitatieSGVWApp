using SollicitatieSGVW.Entity;
using SollicitatieSGVW.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Services.Implementation
{
    public class SollicitantService : ISollicitantService
    {
        private readonly ApplicationDbContext _context;
        public SollicitantService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Sollicitant newSollicitant)
        {
            await _context.Sollicitanten.AddAsync(newSollicitant);
            await _context.SaveChangesAsync();
        }

        public Sollicitant GetById(int sollicitantId) => _context.Sollicitanten.Where(e => e.Id == sollicitantId).FirstOrDefault();

        public async Task Delete(int sollicitantId)
        {
            var sollicitant = GetById(sollicitantId);
            _context.Remove(sollicitant);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Sollicitant> GetAll() => _context.Sollicitanten;

        public async Task UpdateAsync(Sollicitant sollicitant)
        {
            _context.Update(sollicitant);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var sollicitant = GetById(id);
            _context.Update(sollicitant);
            await _context.SaveChangesAsync();
        }
    }
}
