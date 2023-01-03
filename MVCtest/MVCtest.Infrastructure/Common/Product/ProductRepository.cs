using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;

namespace MVCtest.Infrastructure.Common.Product
{
    public class ProductRepository : Repository<Models.Product>, IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Models.Product product)
        {
            var objFromDb = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.Price = product.Price;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverId = product.CoverId;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price50=product.Price50;
                objFromDb.Price100=product.Price100;
                if (objFromDb.ImgURL != null)
                {
                    objFromDb.ImgURL = product.ImgURL;
                }

            }

        }
    }
}
