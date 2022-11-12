using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class HousRentingServiseCollectonExtensions
    {
        public static IServiceCollection AddAplicationServises(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IHouseService,HouseService>();
            services.AddScoped<IAgentService,AgentService>();
            return services;
        }
    }
}
