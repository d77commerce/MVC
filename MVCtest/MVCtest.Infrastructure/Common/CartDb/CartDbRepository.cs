using MVCtest.Data;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Infrastructure.Common.cartDb

{
    public class CartDbRepository : Repository<Models.CartDb>, ICartDbRepository
    {
        private ApplicationDbContext _context;
        public CartDbRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        } 

    }
}
