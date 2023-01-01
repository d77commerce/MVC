using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Infrastructure.Common.Category;
using MVCtest.Infrastructure.Common.Cover;

namespace MVCtest.Infrastructure.Common
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICoverRepository Cover { get; }

        void Save();
    }
}
