using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Users
{
    public class RegisteredWebUser : User
    {
        private string username;

        public RegisteredWebUser(string name, string email, string password, DateTime joinDate, string username) : base(name, email, password, joinDate)
        {
            this.username = username;
        }

        public RegisteredWebUser(int id, string name, string email, string password, DateTime joinDate, string username) : base(id, name, email, password, joinDate)
        {
            this.username = username;
        }

        public RegisteredWebUser()
        {

        }

        [Required(ErrorMessage = "A username is required")]
        public string Username { get { return username; } set { this.username = value; } }


        public override string ToString()
        {
            return $"{this.username}";
        }
    }
}
