using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;

namespace MVCtest.Infrastructure.Common.OrderHeader
{
	public class OrderHeaderRepository : Repository<Models.OrderHeader>,IOrderHeaderRepository
	{
		private readonly ApplicationDbContext _context;
		public OrderHeaderRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public void Update(Models.OrderHeader obj)
		{
			_context.OrderHeaders.Update(obj);
		}

		public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
		{
			var orderFromDb = _context.OrderHeaders.FirstOrDefault(u => u.Id == id);
			if (orderFromDb == null) return;
			orderFromDb.OrderStatus=orderStatus;
			if (paymentStatus != null)
			{
				orderFromDb.PaymentStatus=paymentStatus;
			}

		}
	}
}
