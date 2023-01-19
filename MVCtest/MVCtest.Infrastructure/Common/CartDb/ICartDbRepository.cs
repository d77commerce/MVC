using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Infrastructure.Common.cartDb
{
   public interface ICartDbRepository:IRepository<Models.CartDb>
   {
     
     int PlusCount(CartDb cartDb,int count);
     int MinusCount(CartDb cartDb,int count);
   }
}
