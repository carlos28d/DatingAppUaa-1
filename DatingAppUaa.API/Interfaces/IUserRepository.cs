using DatingAppUaa.API.DTOs;
using DatingAppUaa.API.Entities;
using DatingAppUaa.API.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppUaa.API.Interfaces
{
    // Repository Design Pattern
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}
