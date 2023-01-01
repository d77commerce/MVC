using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Infrastructure.Common.Cover
{
   public interface ICoverRepository :IRepository<Models.Cover>
    {
        void Update(Models.Cover cover);
    }
}
