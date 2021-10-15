using DatingApp.API.Entities;
using DatingAppUaa.API.DTOs;
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
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);
    }
}
