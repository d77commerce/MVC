using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Core.Contracts;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models.Identity;

namespace MVCtest.Core.Servises
{
    public class AdministrationServices : IAdministrationServices
    {
        private readonly ApplicationUser _applicationUser;

        public AdministrationServices(UnitOfWork unitOfWork, ApplicationUser applicationUser)
        {
            _applicationUser=applicationUser;
        }

        public Task<Guid> GetIdByEmail(string email)
        {
            throw new NotImplementedException();
        }




        /*public async Task<string> GetIdByEmail(string email)
        {
            var userId = _applicationUser.Id.ToString();

            return await userId;
        }*/
    }
}
