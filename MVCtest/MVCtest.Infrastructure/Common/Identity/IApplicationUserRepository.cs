using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Infrastructure.Models.Identity;

namespace MVCtest.Infrastructure.Common.Identity
{
    public interface IApplicationUserRepository :IRepository<ApplicationUser>
    {
        void Update(Models.Identity.ApplicationUser user);
    }
}
