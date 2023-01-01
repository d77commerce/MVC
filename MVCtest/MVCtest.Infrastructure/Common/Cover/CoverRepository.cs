using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Data;

namespace MVCtest.Infrastructure.Common.Cover
{
    internal class CoverRepository : Repository<Models.Cover>, ICoverRepository
    {
        private ApplicationDbContext _context;
        public CoverRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Models.Cover cover)
        {
            _context.Covers.Update(cover);
        }
    }
}
