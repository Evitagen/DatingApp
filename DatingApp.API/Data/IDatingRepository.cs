using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Helpers;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;    // constrain where T is a type of class
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();
         Task<PagedList<user>> GetUsers(UserParams userParams);

         Task<user> GetUser(int id, bool isCurrentUser);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
        Task GetUser(object userid);
        Task<Like> GetLike(int userId, int recipientId);

        Task<Message> GetMessage(int id);

        Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<Message>> GetMessageThread(int userID, int recipientId);

    }
}