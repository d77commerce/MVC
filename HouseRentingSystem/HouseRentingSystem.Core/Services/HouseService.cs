using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Servises
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repo;
        public HouseService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<HouseHomeModel>> LastThreeHouses()
        {
            return await repo.AllReadonly<House>()
                .OrderByDescending(x => x.Id)
                .Select(h => new HouseHomeModel()
                {
                    Id = h.Id,
                    ImgURL = h.ImageUrl,
                    Title = h.Title
                })
                .Take(3)
                .ToListAsync();
        }
    }
}
