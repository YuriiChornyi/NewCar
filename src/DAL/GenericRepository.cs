using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _db;

        public GenericRepository(DbContext context)
        {
            _db = context;
        }
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            _db.Set<T>().AddRange(items);
        }

        public void Remove(int id)
        {
            var itemToRemove = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(itemToRemove);
        }

        public void RemoveRange(IEnumerable<T> items)
        {
            _db.Set<T>().RemoveRange(items);
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>();
        }

        public T Update(T entity)
        {
            _db.Set<T>().Attach(entity);
            var entry = _db.Entry(entity);
            entry.State = EntityState.Modified;
            return entity;
        }
    }
}
