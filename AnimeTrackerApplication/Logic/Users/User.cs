using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Users
{
    public abstract class User
    {
        protected int id;
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
            this.id = 0;
        }

        public User(int id, string name, string email, string password, DateTime joinDate)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.joinDate = joinDate;
            this.id = id;
        }

        public User()
        {

        }

        [Required(ErrorMessage = "A name is required!")]
        public string Name { get { return name; } set { this.name = value; } }

        [Required(ErrorMessage = "An email is required"),
         EmailAddress(ErrorMessage = "Your email address must be valid!")]
        public string Email { get { return email; } set { this.email = value; } }

        [Required(ErrorMessage = "A password is required"),
         MinLength(6, ErrorMessage = "Your password need to be at least 6 characters!")]
        public string Password { get { return password; } set { this.password = value; } }

        public DateTime JoinDate { get { return joinDate; } set { this.joinDate = value; } }

        public int Id { get { return id; } set { id = value; } }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
