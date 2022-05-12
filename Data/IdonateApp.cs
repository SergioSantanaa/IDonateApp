using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IDonateApp.Models;

    public class IdonateApp : DbContext
    {
        public IdonateApp (DbContextOptions<IdonateApp> options)
            : base(options)
        {
        }

        public DbSet<IDonateApp.Models.Avaliacao> Avaliacao { get; set; }

        public DbSet<IDonateApp.Models.Agendamento> Agendamento { get; set; }

        public DbSet<IDonateApp.Models.Doacao> Doacao { get; set; }

        public DbSet<IDonateApp.Models.Ong> Ong { get; set; }

        public DbSet<IDonateApp.Models.Usuario> Usuario { get; set; }
    }
