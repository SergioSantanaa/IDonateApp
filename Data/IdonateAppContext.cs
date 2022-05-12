using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IDonateApp.Models;

    public class IdonateAppContext : DbContext
    {
        public IdonateAppContext (DbContextOptions<IdonateAppContext> options)
            : base(options)
        {
        }

        public DbSet<IDonateApp.Models.Anuncio> Anuncio { get; set; }
    }
