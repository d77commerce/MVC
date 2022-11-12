
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class AgentService : IAgentService
    {
  private readonly IRepository repo;

        public AgentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<bool> ExistsById(string userId)
        {
          return await repo.All<Agent>()
                .AnyAsync(a=>a.UserId==userId);
        }
    }
}
