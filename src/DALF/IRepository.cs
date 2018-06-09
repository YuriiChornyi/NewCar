namespace DALF
{
    using System.Collections.Generic;
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
