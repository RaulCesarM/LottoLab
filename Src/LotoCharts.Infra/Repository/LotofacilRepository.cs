
using LotoCharts.Domain.Entities.Models;
using LotoCharts.Domain.Interfaces.IRepository;
using LotoCharts.Infra.Context;

namespace LotoCharts.Infra.Repository
{
    public class LotofacilRepository : BaseGenericCrudRepository<LotoFacil, int>, ILotoFacilRepository
    {
        private readonly LotoChartsContext _context;
        public LotofacilRepository(LotoChartsContext context) : base(context)
        {
            _context = context;
        }

      
    }
}