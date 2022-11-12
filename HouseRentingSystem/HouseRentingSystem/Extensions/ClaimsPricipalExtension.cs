using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace HouseRentingSystem.Extensions
{
    public static class ClaimsPricipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
