using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Infrastructure.Common;

namespace MVCtest.Infrastructure.Common.Category
{
   public interface ICategoryRepository:IRepository<Models.Category>
   {
       void Update(Models.Category obj);
       void Save();
   }
}
