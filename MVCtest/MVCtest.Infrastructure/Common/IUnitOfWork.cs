using MVCtest.Infrastructure.Common.Category;
using MVCtest.Infrastructure.Common.Cover;
using MVCtest.Infrastructure.Common.Product;

namespace MVCtest.Infrastructure.Common
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICoverRepository Cover { get; }
        IProductRepository  Product { get; }

        void Save();
    }
}
