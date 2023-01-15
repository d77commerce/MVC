using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Core.Contracts
{
    public interface IAdministrationServices
    {
        Task<Guid>GetIdByEmail(string email);
    }
}
