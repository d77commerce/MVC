﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IAgentService
    {
      Task<bool> UserWithPhoneNumberExists(string phoneNumber);
        Task <bool> ExistsById(string userId);

        Task<bool> UserHasRents(string userId);

        Task Create(string userId, string phoneNumber);

        Task<int> GetAgentId(string userId);
    }
}
