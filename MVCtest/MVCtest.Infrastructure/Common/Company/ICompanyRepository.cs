using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Infrastructure.Common.Company
{
    public interface ICompanyRepository:IRepository<Models.Company>
    {
        void Update(Models.Company company);
    }
}
