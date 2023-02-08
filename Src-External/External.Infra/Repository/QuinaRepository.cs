using External.Domain.Entities.Models;
using External.Domain.Interfaces.IRepository;
using External.Infra.Context;
namespace External.Infra.Repository
{
    public class QuinaRepository : BaseGenericCrudRepository<Quina, int>, IQuinaRepository
    {
        public QuinaRepository(LotoChartsContext context) : base(context)
        {
        }
    }
}