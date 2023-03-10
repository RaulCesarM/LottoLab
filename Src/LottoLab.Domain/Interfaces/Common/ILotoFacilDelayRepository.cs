
using LottoLab.Domain.Data.Models;

namespace LottoLab.Domain.Interfaces.Common
{
    public interface ILotoFacilDelayRepository
    {
        void Insert(LotoFacilDelay entity);
        LotoFacilDelay GetById(int id);
        int GetFirst();
        int GetLast();
    }
}