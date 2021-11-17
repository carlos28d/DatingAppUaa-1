using DatingAppUaa.API.DTOs;
using DatingAppUaa.API.Entities;
using DatingAppUaa.API.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppUaa.API.Interfaces
{
    public interface IMessagesRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUsername, string recipientUsername);
        Task<bool> SaveAllAsync();
    }
}
