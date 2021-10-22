using System.Security.Claims;

namespace DatingAppUaa.API.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        // DRY Principle - Don't Repeat Yourself
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
