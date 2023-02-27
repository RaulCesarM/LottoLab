namespace LotoCharts.Domain.Interfaces.Utilities
{
       public interface ISupplyLotoFacil
    {
        Task<int>  CheckLast();

        Task Feed(int lastDB);

    }
}