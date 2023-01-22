

using LotoCharts.Domain.Interfaces.IRepository;
using LotoCharts.Domain.Interfaces.IServices;
using LotoCharts.Domain.Services;
using LotoCharts.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace LotoCharts.Di.IOC
{
    public class RepositoryIOC
    {
        public static void RegisterServices(IServiceCollection builder)
        {
            builder.AddScoped<ILotoFacilRepository, LotofacilRepository>();
            builder.AddScoped<ILotoFacilService, LotoFacilServices>();
            builder.AddScoped<ILotoFacilFeedService, FeedBusService>();
        }
    }
}