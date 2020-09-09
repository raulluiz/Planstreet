using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Planstreet.ApplicationCore.Entities;
using Planstreet.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Planstreet.Infrastructure.Context
{
    public class PlanstreetContext : DbContext
    {
        public PlanstreetContext() { }

        public PlanstreetContext(DbContextOptions<PlanstreetContext> opcoes) : base(opcoes) { }

        public DbSet<DefaultFolder> DefaultFolder { get; set; }
        public DbSet<DocumentFolder> DocumentFolder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration.Remove<PluralizingTableNameConvention>(); //plularização de objetos
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //deleção em cascata de filho
            modelBuilder.ApplyConfiguration(new DefaultFolderConfig());
            modelBuilder.ApplyConfiguration(new DocumentFolderConfig());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
