using LottoLab.Domain.Interfaces.Common;
using LottoLab.Domain.Services;
using LottoLab.Infra.Data.Context;
using LottoLab.Infra.DataBase.Repository;
using LottoLab.Lib.Worker.Services;
using LottoLab.Lib.Worker.Workers;

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