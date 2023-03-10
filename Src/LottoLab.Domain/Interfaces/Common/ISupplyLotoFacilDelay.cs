
namespace LottoLab.Domain.Interfaces.Common
{
    public interface ISupplyLotoFacilDelay
    {
        int CheckLast();
        int Feed(int lastDB);
    }
}