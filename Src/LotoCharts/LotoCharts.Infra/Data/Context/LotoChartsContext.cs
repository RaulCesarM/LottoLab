using LotoCharts.Domain.Entities.Models;
using LotoCharts.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LotoCharts.Infra.Data.Context
{
    public class LotoChartsContext: DbContext
    {
        public DbSet<LotoFacil> LotoFacilContext { get; set; }
        // public DbSet<MegaSena> MegaSenas { get; set; }
        // public DbSet<Quina> Quinas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LotoFacilMapping());
            // modelBuilder.ApplyConfiguration(new MegaSenaMapping());
            // modelBuilder.ApplyConfiguration(new QuinaMapping());
        }

    }
}