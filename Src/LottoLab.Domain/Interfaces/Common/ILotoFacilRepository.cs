
using LottoLab.Domain.Data.Models;

namespace LottoLab.Domain.Interfaces.Common
{
    public interface ILotoFacilRepository
    {
        
        void Insert(LotoFacil entity);
        LotoFacil GetById(int id);
        int GetFirst();
        int GetLast();
    }
}