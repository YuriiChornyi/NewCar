using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T item);
        void AddRange(IEnumerable<T> items);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> items);
    }
}
