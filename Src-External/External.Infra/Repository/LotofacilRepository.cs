using External.Domain.Entities.Models;
using External.Domain.Interfaces.IRepository;
using External.Infra.Context;
namespace External.Infra.Repository
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