using System;
using System.Threading.Tasks;
using LFSCore.Models;
using Microsoft.EntityFrameworkCore;

namespace NetCore.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        public QLCContext _context { get; }
        
        public AuthRepository(QLCContext context)
        {
            _context = context;
        }

        public async Task<User> Login(string username, string password)
        {
            var _user = await _context.User.FirstOrDefaultAsync(c=>c.Username == username);

            if(_user == null)
            return null;

            if(!ValidatePassword(password, _user.Password))
            return null;

            return _user;
        }

        private bool ValidatePassword(string password, byte[] _password)
        {
            var pass = System.Text.Encoding.UTF8.GetBytes(password);

            for(int i=0;i<pass.Length;i++)
            {

                if(pass[i] != _password[i])
                return false;
            }

            return true;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] _password;
            CreatePasswordHash(password,out _password);

            user.Password = _password;

            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private void CreatePasswordHash(string password, out byte[] _password)
        {
            _password = System.Text.Encoding.UTF8.GetBytes(password);
        }

        public async Task<bool> UserExist(string username)
        {
            if(await _context.User.AnyAsync(x=>x.Username == username))
            return true;

           return false;
        }
    }
}