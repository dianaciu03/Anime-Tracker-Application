using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Users
{
    public class Admin : User
    {

        public Admin(string name, string email, string hashedPassword, DateTime joinDate, string salt) : base(name, email, hashedPassword, joinDate, salt)
        {
        }

        public Admin(int id, string name, string email, string hashedPassword, DateTime joinDate, string salt) : base(id, name, email, hashedPassword, joinDate, salt)
        {
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
