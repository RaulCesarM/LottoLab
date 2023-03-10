using LottoLab.Domain.Data.DTO;

namespace LottoLab.Domain.Interfaces.Common
{
    public interface ILotoFacilService
    {
         void Insert(LotoFacilDTO entity);
        LotoFacilDTO GetById(int id);
        int GetFirst();
        int GetLast();
    }
}