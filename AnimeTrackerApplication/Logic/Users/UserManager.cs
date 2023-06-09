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
        private UserDataValidator udv;

        public UserManager(IUserRepository iUser)
        {
            _userDataHandler = iUser;
            udv = new UserDataValidator();
        }

        public List<User> GetAllUsers()
        {
            return _userDataHandler.GetAllUsers();
        }

        public List<RegisteredWebUser> GetAllWebUsers()
        {
            return _userDataHandler.GetAllWebUsers();
        }

        public void AddUser(string name, string email, string role)
        {
            try
            {
                if(udv.IsNameValid(name) && udv.IsEmailValid(email))
                {
                    if (role == "Maintainer")
                    {
                        User maintainer = new Maintainer(name, email, "", DateTime.Now.Date, "");
                        _userDataHandler.AddUser(maintainer);
                    }
                    else if (role == "Admin")
                    {
                        User admin = new Admin(name, email, "", DateTime.Now.Date, "");
                        _userDataHandler.AddUser(admin);
                    }
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateUser(User user, string password)
        {
            try
            {
                if(udv.IsPasswordValid(password))
                {
                    (string salt, string hashedPassword) = Security.CreateSaltAndHash(password);
                    user.Salt = salt;
                    user.HashedPassword = hashedPassword;
                    _userDataHandler.UpdateUser(user);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddWebUser(string name, string email, string password, string username)
        {
            try
            {
                if (udv.IsNameValid(name) && udv.IsEmailValid(email) && udv.IsPasswordValid(password))
                {
                    (string salt, string hashedPassword) = Security.CreateSaltAndHash(password);
                    Profile webProfile = new Profile(username);
                    RegisteredWebUser webUser = new RegisteredWebUser(name, email, hashedPassword, DateTime.Now.Date, salt, webProfile);
                    _userDataHandler.AddUser(webUser);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<User> GetSearchedUsers(string nameU, string usernameU, string roleU, int yearsU)
        {
            return _userDataHandler.GetSearchedUsers(nameU, usernameU, roleU, yearsU);
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
                if (user.Email == email && user.HashedPassword == Security.CreateHash(user.Salt, password))
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteAccount(int userId)
        {
            _userDataHandler.DeleteAccount(userId);
        }
    }
}
