using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repo;
        public HouseService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<HouseCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new HouseCategoryModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExist(int CategoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.Id == CategoryId);
        }

        public async Task<int> Create(HouseModel model)
        {
            var house = new House()
            {
                Title = model.Title,
                 Address = model.Address,
                 CategoryId = model.CategoryId,
                 Description=  model.Description,
                 ImageUrl= model.ImgURL,
                 PricePerMonth =    model.PricePerMount

            };
            await repo.AddAsync(house);
            await repo.SaveChangesAsync();
            return house.Id;
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
