using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Servises;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class HousRentingServiseCollectonExtensions
    {
        public static IServiceCollection AddAplicationServises(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IHouseService,HouseService>();
            return services;
        }
    }
}
