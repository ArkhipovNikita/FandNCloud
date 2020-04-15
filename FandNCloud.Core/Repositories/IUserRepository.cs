using System.Collections.Generic;
using System.Threading.Tasks;
using FandNCloud.Core.Models;

namespace FandNCloud.Core.Repositories
{
    public  interface IUserRepository
    {
        Task<User> Authenticate(string email, string password);
        Task<User> Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetWithUsersByIdAsync(int id);
    }
}