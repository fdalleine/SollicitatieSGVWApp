using SollicitatieSGVW.Entity;
using SollicitatieSGVW.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SollicitatieSGVW.Services.Implementation
{
    public class ScholenService : IScholenService
    {
        private readonly ApplicationDbContext _context;
        public ScholenService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Scholen GetById(int schoolId) => _context.Scholen.Where(e => e.Id == schoolId).FirstOrDefault();
    }
}
