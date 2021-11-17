using DatingAppUaa.API.Entities;
using System.Threading.Tasks;

namespace DatingAppUaa.API.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
