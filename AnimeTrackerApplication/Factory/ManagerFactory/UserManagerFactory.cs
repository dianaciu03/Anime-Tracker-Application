using DAL.Repositories;
using Logic.Animes;
using Logic.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ManagerFactory
{
    public static class UserManagerFactory
    {
        public static UserManager CreateUserManager(IUserRepository userRepository)
        {
            return new UserManager(userRepository);
        }

    }
}
