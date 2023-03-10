
using LottoLab.Domain.Data.Models;
using LottoLab.Domain.Interfaces.Common;
using LottoLab.Infra.Data.Context;

namespace LottoLab.Infra.DataBase.Repository
{
    public class LotoFacilDelayRepository : ILotoFacilDelayRepository
    {
        private readonly LotoChartsContext _context;
        public LotoFacilDelayRepository(LotoChartsContext context)
        {
              _context = context;
        }
        public LotoFacilDelay GetById(int id)
        {
            return _context.LotoFacilDelayContext.Find(id);
        }

        public int GetFirst()
        {
            var first = _context.LotoFacilDelayContext
                                 .FirstOrDefault();
            if (first == null)
            {
                first.Concurso = 1;
            }
            return first.Id;
        }

        public int GetLast()
        {
            var latest = _context.LotoFacilDelayContext
                                 .OrderBy(x => x)
                                 .LastOrDefault();
            if (latest == null)
            {
                return 0;
            }
            return latest.Concurso;
        }

        public void Insert(LotoFacilDelay entity)
        {
            _context.LotoFacilDelayContext
                                .Add(entity);
            _context.SaveChanges();
        }
    }
}