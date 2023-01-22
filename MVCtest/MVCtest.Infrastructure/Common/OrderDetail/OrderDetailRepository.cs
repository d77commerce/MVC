using MVCtest.Data;

namespace MVCtest.Infrastructure.Common.OrderDetail
{
    public class OrderDetailRepository : Repository<Models.OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Models.OrderDetail obj)
        {
            _context.OrderDetails.Update(obj);
        }
    }
}
