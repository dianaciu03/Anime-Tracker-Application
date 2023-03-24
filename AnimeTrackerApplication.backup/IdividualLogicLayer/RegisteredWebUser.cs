using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public class RegisteredWebUser : User
    {
        private string username;
        private string passwordConfirm;


        public RegisteredWebUser(string name, string email, string password, DateTime joinDate, string username) : base(name, email, password, joinDate)
        {
            this.username = username;
        }

        public RegisteredWebUser()
        {

        }

        [Required(ErrorMessage = "A username is required")]
        public string Username { get { return username; } set { this.username = value; } }

        public string PasswordConfirm { get { return passwordConfirm; } set { this.passwordConfirm = value; } }


        public override string ToString()
        {
            return $"{this.username}";
        }
    }
}
