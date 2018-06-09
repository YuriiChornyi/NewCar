namespace DALF
{
    using System.Collections.Generic;
    using System.Data.Entity;

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly CarDbContext _carDb;

        public GenericRepository(CarDbContext context)
        {
            _carDb = context;
        }
        public void Add(T item)
        {
            _carDb.Set<T>().Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            _carDb.Set<T>().AddRange(items);
        }

        public void Remove(int id)
        {
            var itemToRemove = _carDb.Set<T>().Find(id);
            _carDb.Set<T>().Remove(itemToRemove);
        }

        public void RemoveRange(IEnumerable<T> items)
        {
            _carDb.Set<T>().RemoveRange(items);
        }

        public T Get(int id)
        {
            return _carDb.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _carDb.Set<T>();
        }

        public void Update(T entity)
        {
            _carDb.Entry(entity).State = EntityState.Modified;
        }
    }
}
