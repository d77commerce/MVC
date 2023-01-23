using MVCtest.Data;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Infrastructure.Common.cartDb

{
    public class CartDbRepository : Repository<CartDb>, ICartDbRepository
    {
        private ApplicationDbContext _context;
        public CartDbRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public int PlusCount(CartDb cartDb, int count)
        {
            cartDb.Count += count;
            return cartDb.Count;
        }

        public int MinusCount(CartDb cartDb, int count)
        {
            cartDb.Count-=count;
            return cartDb.Count;
        }
    }
}
