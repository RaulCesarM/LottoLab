
namespace LotoCharts.Domain.Interfaces.IBases
{
    public interface IBaseRepository<TEntity, Tkey> where TEntity : class
    {
        void SalvarSorteio(TEntity entity);
        void Update(TEntity entity);
    }
}