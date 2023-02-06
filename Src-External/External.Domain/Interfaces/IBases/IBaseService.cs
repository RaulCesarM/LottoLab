

namespace External.Domain.Interfaces.IBases
{
    public interface IBaseService<TEntity, Tkey> where TEntity : class
    {
        void Insert(TEntity entity);
        TEntity GetById(Tkey id);
        TEntity GetFirst();
        TEntity GetLast();
    }
}