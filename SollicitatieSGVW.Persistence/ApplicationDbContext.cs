using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SollicitatieSGVW.Entity;

namespace SollicitatieSGVW.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TewerkstellingsRecord> TewerkstellingsRecords { get; set; }
        public DbSet<Sollicitant> Sollicitanten { get; set; }
    }
}
