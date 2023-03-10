

using LottoLab.Domain.Data.DTO;
using LottoLab.Domain.Data.Models;
using LottoLab.Domain.Interfaces.Common;

namespace LottoLab.Domain.Services
{
    public class LotoFacilDelayService : ILotoFacilDelayService
    {
        private readonly ILotoFacilDelayRepository _Repository;
         public LotoFacilDelayService(ILotoFacilDelayRepository Repository)
        {
            _Repository = Repository;
        }
        public LotoFacilDelayDTO GetById(int id)
        {
             return new LotoFacilDelayDTO(_Repository.GetById(id));
        }

        public int GetFirst()
        {
            return _Repository.GetFirst();
        }

        public int GetLast()
        {
             return _Repository.GetLast();
        }

        public void Insert(LotoFacilDelayDTO entity)
        {
           var lotoFacilDelay = new LotoFacilDelay(entity);
            _Repository.Insert(lotoFacilDelay);
        }
    }
}