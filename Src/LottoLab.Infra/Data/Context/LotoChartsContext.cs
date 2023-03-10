using Microsoft.Extensions.Configuration;
using LottoLab.Domain.Data.Models;
using LottoLab.Infra.DataBase.Mappings;
using Microsoft.EntityFrameworkCore;



namespace LottoLab.Infra.Data.Context
{
    public class LotoChartsContext : DbContext
    {
        public DbSet<LotoFacil> LotoFacilContext { get; set; }
        public DbSet<LotoFacilDelay> LotoFacilDelayContext { get; set; }
        // public DbSet<MegaSena> MegaSenas { get; set; }
        // public DbSet<Quina> Quinas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
            // .SetBasePath(Directory.GetCurrentDirectory())
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LottoLab.Application"))
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LotoFacilMapping());
            modelBuilder.ApplyConfiguration(new LotoFacilDelayMapping());
            // modelBuilder.ApplyConfiguration(new MegaSenaMapping());
            // modelBuilder.ApplyConfiguration(new QuinaMapping());
        }
    }
}
