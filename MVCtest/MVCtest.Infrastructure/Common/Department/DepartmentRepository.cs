using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;

namespace MVCtest.Infrastructure.Common.Department
{
    public class DepartmentRepository:Repository<Models.Department> ,IDepartmentRepository
    {
        private ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Models.Department department)
        {
            _context.Departments.Update(department);
        }
    }
}
