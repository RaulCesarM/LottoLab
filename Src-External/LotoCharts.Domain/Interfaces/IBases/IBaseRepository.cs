
namespace LotoCharts.Domain.Interfaces.IBases
{
    public interface IBaseRepository<TEntity, Tkey> where TEntity : class
    {
        void Insert(TEntity entity);      
        TEntity GetById(Tkey id);
        TEntity GetFirst();
        TEntity GetLast();
    }
}