using LotoCharts.Domain.Entities.DTOs;

namespace LotoCharts.Domain.Interfaces.Services
{
    public interface ILotoFacilService
    {
         void Insert(LotoFacilDTO entity);
        LotoFacilDTO GetById(int id);
        int GetFirst();
        int GetLast();
    }
}