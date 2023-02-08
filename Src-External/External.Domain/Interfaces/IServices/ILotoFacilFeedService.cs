
namespace External.Domain.Interfaces.IServices
{
    public interface ILotoFacilFeedService
    {
        Task<int> CheckLast();
        Task<int> Update(int i);
    }
}