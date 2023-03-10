
using LottoLab.Domain.Data.DTO;

namespace LottoLab.Domain.Interfaces.Common
{
    public interface ILotoFacilDelayService
    {
        void Insert(LotoFacilDelayDTO entity);
        LotoFacilDelayDTO GetById(int id);
        int GetFirst();
        int GetLast();
    }
}