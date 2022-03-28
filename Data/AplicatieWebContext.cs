using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplicatieWeb.Models;

namespace AplicatieWeb.Data
{
    public class AplicatieWebContext : DbContext
    {
        public AplicatieWebContext (DbContextOptions<AplicatieWebContext> options)
            : base(options)
        {
        }

        public DbSet<AplicatieWeb.Models.Client> Client { get; set; }

        public DbSet<AplicatieWeb.Models.Meniu> Meniu { get; set; }

        public DbSet<AplicatieWeb.Models.Rezervare> Rezervare { get; set; }
    }
}
