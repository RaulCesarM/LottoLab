using LotoCharts.Domain.Entities.Models;

namespace LotoCharts.Domain.Interfaces.Respository
{
    public interface ILotoFacilRepository
    {
        void Insert(LotoFacil entity);
        LotoFacil GetById(int id);
        int GetFirst();
        int GetLast();
    }
}