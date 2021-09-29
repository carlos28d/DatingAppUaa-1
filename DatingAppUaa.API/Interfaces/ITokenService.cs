using DatingApp.API.Entities;

namespace DatingAppUaa.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
