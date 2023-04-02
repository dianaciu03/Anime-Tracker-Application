using Logic.Animes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Users
{
    public class UserManager
    {
        private readonly IUser _userDataHandler;

        public UserManager(IUser iUser)
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

        //public List<User> GetUsers()
        //{
            
        //}
    }
}
