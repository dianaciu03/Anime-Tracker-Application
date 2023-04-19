using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Users
{
    public class Maintainer : User
    {
        public Maintainer(string name, string email, string password, DateTime joinDate) : base(name, email, password, joinDate)
        {

        }

        public Maintainer(int id, string name, string email, string password, DateTime joinDate) : base(id, name, email, password, joinDate)
        {

        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
