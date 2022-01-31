using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlanetsWebApp.Models;

namespace PlanetsWebApp.Data
{
    public class PlanetsWebAppContext : DbContext
    {
        public PlanetsWebAppContext (DbContextOptions<PlanetsWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<PlanetsWebApp.Models.Planet> Planet { get; set; }
    }
}
