using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;    // constrain where T is a type of class
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();
         Task<IEnumerable<user>> GetUsers();

         Task<user> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
    }
}