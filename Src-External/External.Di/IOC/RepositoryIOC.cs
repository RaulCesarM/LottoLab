using External.Domain.Interfaces.IRepository;
using External.Domain.Interfaces.IServices;
using External.Domain.Services;
using External.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace External.Di.IOC
{
    public class RepositoryIOC
    {
        public static void RegisterServices(IServiceCollection builder)
        {
            builder.AddScoped<ILotoFacilRepository, LotofacilRepository>();
            builder.AddScoped<ILotoFacilService, LotoFacilServices>();
            builder.AddScoped<ILotoFacilFeedService, FeedLotoFacil>();
        }
    }
}