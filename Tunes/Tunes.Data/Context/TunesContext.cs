using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using System;
using Tunes.Business.Models;

namespace Tunes.Data.Context
{
    public class TunesContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Tunes;Trusted_Connection=true;")
                .UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TunesContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
