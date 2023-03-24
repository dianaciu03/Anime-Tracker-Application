using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public class UserManager
    {
        List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }

        public void AddUser(User webUser)
        {
            users.Add(webUser);
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
