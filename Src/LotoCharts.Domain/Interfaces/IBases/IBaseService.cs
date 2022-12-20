

namespace LotoCharts.Domain.Interfaces.IBases
{
    public interface IBaseService<TEntity, Tkey> where TEntity : class
    {
    //  IList<TEntity> GetAll(Pagination pagination);
    //    TEntity GetById(Tkey id);
        int SalvarSorteio(TEntity entity);
    //    void Remove(Tkey id);
        void Update(TEntity entity, Tkey id);
     //   int GetTotal(); 
    }
}