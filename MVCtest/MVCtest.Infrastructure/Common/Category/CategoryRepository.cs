using MVCtest.Data;

namespace MVCtest.Infrastructure.Common.Category
{
    public class CategoryRepository : Repository<Models.Category>, ICategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Models.Category obj)
        {
            _context.Categories.Update(obj);
        }
    }
}
