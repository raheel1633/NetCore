using System.Threading.Tasks;
using LFSCore.Models;

namespace NetCore.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user,string password);
         Task<User> Login(string username,string password);
         Task<bool> UserExist(string username);
    }
}