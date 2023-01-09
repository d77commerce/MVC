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
            _context.Products.Include(u => u.Category).Include(u => u.Cover);
            dbSet = _context.Set<T>();
        }
        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
           IQueryable<T> query = dbSet.Where(filter);
           if (includeProperties != null)
           {
               foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
               {
                   query = query.Include(includeProperty);
               }
           }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[]{ ','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
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
