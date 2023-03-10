using LottoLab.Domain.Data.Models;
using LottoLab.Domain.Interfaces.Common;
using LottoLab.Infra.Data.Context;

namespace LottoLab.Infra.DataBase.Repository
{
    public class LotoFacilRepository : ILotoFacilRepository
    {
          private readonly LotoChartsContext _context;

        public LotoFacilRepository(LotoChartsContext context)
        {
            _context = context;
        }
        public LotoFacil GetById(int id)
        {
            return _context.LotoFacilContext
                                 .Find(id);
        }
        public int GetFirst()
        {
            var first = _context.LotoFacilContext
                                 .FirstOrDefault();
            if (first == null)
            {
                first.Concurso = 1;
            }
            return first.Id;
        }
        public int GetLast()
        {
            var latest = _context.LotoFacilContext
                                 .OrderBy(x => x)
                                 .LastOrDefault();
            if (latest == null)
            {
                return 0;
            }
            return latest.Concurso;
        }
        public void Insert(LotoFacil entity)
        {
            _context.LotoFacilContext
                                .Add(entity);
            _context.SaveChanges();
        }
    }
}