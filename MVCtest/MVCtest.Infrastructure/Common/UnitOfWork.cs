using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;
using MVCtest.Infrastructure.Common.Category;
using MVCtest.Infrastructure.Common.Company;
using MVCtest.Infrastructure.Common.Cover;
using MVCtest.Infrastructure.Common.Department;
using MVCtest.Infrastructure.Common.Identity;
using MVCtest.Infrastructure.Common.Product; 

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
            Product= new ProductRepository(_context);
            Department = new DepartmentRepository(_context);
            Company = new CompanyRepository(_context);
            ApplicationUser = new ApplicationUser(_context);
        }
        public ICategoryRepository Category { get; private set; }
        public ICoverRepository Cover { get; private set; }

        public IProductRepository Product { get; private set; }
        public IDepartmentRepository Department { get; }
        public ICompanyRepository Company { get; }
        public IApplicationUser ApplicationUser { get; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
