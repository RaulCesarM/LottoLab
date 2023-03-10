using LottoLab.Domain.Interfaces.Common;
using LottoLab.Domain.Services;
using LottoLab.Infra.DataBase.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace LottoLab.DI.Configs
{
    public class Inject
    {
        public static void RegisterServices(IServiceCollection builder)
        {
            builder.AddScoped<ILotoFacilService, LotoFacilServices>();
            builder.AddScoped<ILotoFacilRepository, LotoFacilRepository>();

            builder.AddScoped<ILotoFacilDelayService, LotoFacilDelayService>();
            builder.AddScoped<ILotoFacilDelayRepository, LotoFacilDelayRepository>();
            
        }
    }
}