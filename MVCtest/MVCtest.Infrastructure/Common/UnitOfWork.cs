using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;
using MVCtest.Infrastructure.Common.cartDb;
using MVCtest.Infrastructure.Common.Category;
using MVCtest.Infrastructure.Common.Company;
using MVCtest.Infrastructure.Common.Cover;
using MVCtest.Infrastructure.Common.Department;
using MVCtest.Infrastructure.Common.Identity;
using MVCtest.Infrastructure.Common.OrderDetail;
using MVCtest.Infrastructure.Common.OrderHeader;
using MVCtest.Infrastructure.Common.Product;
using IOrderHeaderRepository = MVCtest.Infrastructure.Common.OrderHeader.IOrderHeaderRepository;

namespace MVCtest.Infrastructure.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            Cover = new CoverRepository(_context);
            Product= new ProductRepository(_context);
            Department = new DepartmentRepository(_context);
            Company = new CompanyRepository(_context);
            ApplicationUser = new ApplicationUserRepository(_context);
            CartDb = new CartDbRepository(_context);
            OrderHeader= new OrderHeaderRepository(_context);
         OrderDetail = new OrderDetailRepository(_context);
        }
       
        public ICoverRepository Cover { get; private set; }
        public  ICategoryRepository Category { get; private set; }

        public IProductRepository Product { get; private set; }
        public IDepartmentRepository Department { get; private set; }
        public ICompanyRepository Company { get; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public ICartDbRepository CartDb { get; private set;  }
        public IOrderDetailRepository OrderDetail { get; private set;  }
        public IOrderHeaderRepository OrderHeader { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
