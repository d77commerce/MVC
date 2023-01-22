using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Infrastructure.Common;

namespace MVCtest.Infrastructure.Common.OrderDetail
{
   public interface IOrderDetailRepository:IRepository<Models.OrderDetail>
   {
       void Update(Models.OrderDetail obj);
     
   }
}
