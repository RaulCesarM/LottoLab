
namespace External.Domain.Interfaces.IServices
{
    public interface IQuinaFeedService
    {
        Task<int> CheckLast();
        Task<int> Update(int i);
    }
}