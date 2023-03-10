

namespace LottoLab.Domain.Interfaces.Bases
{
    public interface IBaseServices<TEntity, Tkey> where TEntity : class
    {

       
        TEntity GetById(Tkey id);
        void Insert(TEntity entity);
        void Remove(Tkey  id);
        void Update(TEntity entity, Tkey id);
        int GetTotal();
    }
}