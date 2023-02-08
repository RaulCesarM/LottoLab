using External.Domain.Entities.Models;
using External.Domain.Interfaces.IRepository;
using External.Infra.Context;
namespace External.Infra.Repository
{
    public class MegaSenaRepository : BaseGenericCrudRepository<MegaSena, int>, IMegaSenaRepository
    {
        private readonly LotoChartsContext _context;
        public MegaSenaRepository(LotoChartsContext context) : base(context)
        {
            _context = context;
        }
    }
}