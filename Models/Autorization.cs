using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Filmography.Models
{

        public class Autorization : IAutorization
        {
            private readonly FG_DbNewContext _context; //контексные классы работаем через сущностни
            private readonly IEncryption _encrypt = new Encryption();
            public static Autorization Instance { get => AuthCreate.instance; }
            private Autorization ()
            {
                _context = new FG_DbNewContext();
            }
            private class AuthCreate
            {
                private AuthCreate() { }
                internal static readonly Autorization instance = new Autorization();
            }

            public async Task<bool> CreateUser(User user)
            {
                try
                {
                    user.Salt = Guid.NewGuid().ToString();
                    user.Password = _encrypt.HashPassword(user.Password, user.Salt);
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public async Task<User> GetUser(int id)
            {
                return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            }

            public async Task<User> GetUser(string login)
            {
                return await _context.Users.FirstOrDefaultAsync(u => u.Login == login);
            }
            public async Task<User> Login(string login, string password)
            {
                User user = await GetUser(login);
                if (user == null)
                    return null;
                if (user.Password == _encrypt.HashPassword(password, user.Salt))
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }
    }
