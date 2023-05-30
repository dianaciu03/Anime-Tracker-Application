using Logic.Animes;
using Logic.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Users
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userDataHandler;

        public UserManager(IUserRepository iUser)
        {
            _userDataHandler = iUser;
        }

        public List<User> GetAllUsers()
        {
            return _userDataHandler.GetAllUsers();
        }

        public List<RegisteredWebUser> GetAllWebUsers()
        {
            return _userDataHandler.GetAllWebUsers();
        }

        public void AddUser(User user)
        {
            _userDataHandler.AddUser(user);
        }

        public void AddWebUser(string name, string email, string password, string username)
        {
            (string salt, string hashedPassword) = Security.CreateSaltAndHash(password);
            Profile webProfile = new Profile(username);
            RegisteredWebUser webUser = new RegisteredWebUser(name, email, hashedPassword, DateTime.Now.Date, salt, webProfile);
            _userDataHandler.AddUser(webUser);
        }

        public bool UserExists(string email)
        {
            foreach (User existUser in GetAllWebUsers())
            {
                if (existUser.Email == email)
                {
                    return true;
                }   
            }
            return false;
        }

        public User? GetUserByEmail(string email)
        {
            return _userDataHandler.GetUserByEmail(email);
        }

        public RegisteredWebUser? GetWebUserByEmail(string email)
        {
            return _userDataHandler.GetWebUserByEmail(email);
        }

        public User? GetUserById(int id)
        {
            return _userDataHandler.GetUserById(id);
        }

        public RegisteredWebUser? GetWebUserById(int id)
        {
            return _userDataHandler.GetWebUserById(id);
        }

        public Profile GetProfileByWebUserId(int id)
        {
            return _userDataHandler.GetProfileByWebUserId(id);
        }

        public bool LoginUser(string password, string email)
        {
            foreach (User user in GetAllUsers())
            {
                if (user.HashedPassword == Security.CreateHash(user.Salt, password) && user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
