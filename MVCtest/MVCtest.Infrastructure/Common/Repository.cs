using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MVCtest.Data;
using MVCtest.Infrastructure.Common;

namespace MVCtest.Infrastructure.Common
{
    public class Repository<T> :IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context=context;
            dbSet = _context.Set<T>();
        }
        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
           IQueryable<T> query = dbSet.Where(filter);
           return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void IsActive(T entity)
        {
            dbSet.Update(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
} 
