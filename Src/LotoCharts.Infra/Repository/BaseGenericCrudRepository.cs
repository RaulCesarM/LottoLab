

using LotoCharts.Domain.Entities.Models;
using LotoCharts.Infra.Context;

namespace LotoCharts.Infra.Repository
{
    public class BaseGenericCrudRepository<TEntity, Tkey> where TEntity : class
    {
        private readonly LotoChartsContext _context;

        public BaseGenericCrudRepository(LotoChartsContext context)
        {
            _context = context;
        }

        public virtual void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }
        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public virtual TEntity GetById(Tkey id)
        {
            return _context.Set<TEntity>().Find(id);
        }



        public virtual IList<TEntity> GetAll(Pagination pagination)
        {
            return _context.Set<TEntity>()
                            .Take(pagination.Take)
                            .Skip(pagination.Skip)
                            .ToList();
        }

        public virtual void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }
    }
}