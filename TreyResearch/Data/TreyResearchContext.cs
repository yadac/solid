using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TreyResearch.Models;

namespace TreyResearch.Data
{
    public class TreyResearchContext : DbContext
    {
        public TreyResearchContext (DbContextOptions<TreyResearchContext> options)
            : base(options)
        {
        }

        public DbSet<TreyResearch.Models.Room> Room { get; set; } = default!;

        public DbSet<TreyResearch.Models.Employee> Employee { get; set; }
    }
}
