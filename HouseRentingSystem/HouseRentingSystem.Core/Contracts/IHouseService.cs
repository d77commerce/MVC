﻿using HouseRentingSystem.Core.Models.House;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseHomeModel>> LastThreeHouses();
        Task<IEnumerable<HouseCategoryModel>> AllCategories();
        Task<bool> CategoryExist(int CategoryId);
        Task<int> Create(HouseModel model);
    }
}
