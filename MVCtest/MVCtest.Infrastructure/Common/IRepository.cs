using System.Linq.Expressions;

namespace MVCtest.Infrastructure.Common
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        T GetFirstOrDefault(Expression<Func<T,bool>> filter);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void IsActive(T entity);
        void RemoveRange(IEnumerable<T> entity);
 
    }
}
