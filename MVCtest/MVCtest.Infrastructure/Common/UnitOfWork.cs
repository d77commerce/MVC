using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;
using MVCtest.Infrastructure.Common.Category;
using MVCtest.Infrastructure.Common.Cover;

namespace MVCtest.Infrastructure.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            Cover = new CoverRepository(_context);
        }
        public ICategoryRepository Category { get; private set; }
        public ICoverRepository Cover { get; private set; }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
