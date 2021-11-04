using DatingAppUaa.API.DTOs;
using DatingAppUaa.API.Entities;
using DatingAppUaa.API.Helpers;
using System.Threading.Tasks;

namespace DatingAppUaa.API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}
