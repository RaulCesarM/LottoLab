using External.Infra.Context;
namespace External.Infra.Repository
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
        public virtual TEntity GetById(Tkey id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public virtual TEntity GetFirst()
        {
            var first = _context.Set<TEntity>()
                                .FirstOrDefault();
            return first;
        }
        public virtual TEntity GetLast()
        {
            var latest = _context.Set<TEntity>()
                                 .OrderBy(x => x)
                                 .LastOrDefault();
            return latest;
        }
    }
}