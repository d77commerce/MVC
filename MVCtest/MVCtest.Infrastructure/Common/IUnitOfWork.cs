using MVCtest.Infrastructure.Common.cartDb;
using MVCtest.Infrastructure.Common.Category;
using MVCtest.Infrastructure.Common.Company;
using MVCtest.Infrastructure.Common.Cover;
using MVCtest.Infrastructure.Common.Department;
using MVCtest.Infrastructure.Common.Identity;
using MVCtest.Infrastructure.Common.Product;

namespace MVCtest.Infrastructure.Common
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICoverRepository Cover { get; }
        IProductRepository  Product { get; }
        IDepartmentRepository Department { get; }
        ICompanyRepository Company { get; }
        IApplicationUserRepository  ApplicationUser { get; }
        ICartDbRepository CartDb { get; }

        void Save();
    }
}
