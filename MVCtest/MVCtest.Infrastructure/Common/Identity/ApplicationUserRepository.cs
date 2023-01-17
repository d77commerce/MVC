using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;

namespace MVCtest.Infrastructure.Common.Identity
{
    public class ApplicationUserRepository :Repository<ApplicationUserRepository>, IApplicationUserRepository
    {
        private ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public void Update(Models.Identity.ApplicationUser user)
        {
            _context.ApplicationUsers.Update(user);
        }
    }
}