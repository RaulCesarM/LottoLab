
namespace External.Domain.Interfaces.IServices
{
    public interface IMegaSenaFeedService
    {
        Task<int> CheckLast();
        Task<int> Update(int i);
    }
}