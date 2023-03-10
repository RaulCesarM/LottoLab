

namespace LottoLab.Domain.Interfaces.Common
{
    public interface ISupplyLotoFacil
    {
        Task<int>  CheckLast();
        Task Feed(int lastDB);
    }
}