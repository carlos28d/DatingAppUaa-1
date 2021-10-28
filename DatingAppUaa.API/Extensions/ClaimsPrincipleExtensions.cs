using System.Security.Claims;

namespace DatingAppUaa.API.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        // DRY Principle - Don't Repeat Yourself
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}
