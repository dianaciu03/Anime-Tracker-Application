using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public abstract class User
    {
        protected string name;
        protected string email;
        protected string password;
        protected DateTime joinDate;

        public User(string name, string email, string password, DateTime joinDate)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.joinDate = joinDate;
        }

        public User()
        {

        }

        public string Name { get { return name; } set { this.name = value; } }

        public string Email { get { return email; } set { this.email = value; } }

        public string Password { get { return password; } set { this.password = value; } }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
