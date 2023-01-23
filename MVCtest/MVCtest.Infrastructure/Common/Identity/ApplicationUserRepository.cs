using MVCtest.Data;
using MVCtest.Infrastructure.Models.Identity;

namespace MVCtest.Infrastructure.Common.Identity
{
    public class ApplicationUserRepository :Repository<ApplicationUser>, IApplicationUserRepository
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