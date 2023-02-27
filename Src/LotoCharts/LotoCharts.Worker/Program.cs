using LotoCharts.Domain.Interfaces.Respository;
using LotoCharts.Domain.Interfaces.Services;
using LotoCharts.Domain.Interfaces.Utilities;
using LotoCharts.Domain.Services;
using LotoCharts.Domain.Utilities;
using LotoCharts.Infra.Data.Context;
using LotoCharts.Infra.Data.Repository;
using LotoCharts.Worker;

class Program
{
    static void Main(string[] args)
    {
        var builder = CreateHostBuilder(args).Build();
        builder.Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddDbContext<LotoChartsContext>();
            services.AddScoped<ILotoFacilRepository, LotoFacilRepository>();
            services.AddScoped<ILotoFacilService, LotoFacilServices>();
            services.AddScoped<ISupplyLotoFacil, SupplyLotoFacil>();
            services.AddHostedService<LotoFacilWorker>();
        });
}

