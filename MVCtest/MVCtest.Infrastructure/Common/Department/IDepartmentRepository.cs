using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Infrastructure.Common.Department
{
    public interface IDepartmentRepository :IRepository<Models.Department>
    {
        void Update(Models.Department department);
    }
}
