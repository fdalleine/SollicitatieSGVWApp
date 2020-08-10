using SollicitatieSGVW.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Services
{
    public interface ITewerkstellingService
    {
        Task CreateAsync(TewerkstellingsRecord tewerkstellingsRecord);
        TewerkstellingsRecord GetById(int id);
        IEnumerable<TewerkstellingsRecord> GetAll();
        
    }
}
