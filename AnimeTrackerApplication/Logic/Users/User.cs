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
        protected string salt;
        protected string password;
        protected string hashedPassword;
        protected DateTime joinDate;

        public User(string name, string email, string hashedPassword, DateTime joinDate, string salt)
        {
            this.name = name;
            this.email = email;
            this.hashedPassword = hashedPassword;
            this.joinDate = joinDate;
            this.salt = salt;
            this.id = 0;
        }

        public User(int id, string name, string email, string hashedPassword, DateTime joinDate, string salt)
        {
            this.name = name;
            this.email = email;
            this.hashedPassword = hashedPassword;
            this.joinDate = joinDate;
            this.salt = salt;
            this.id = id;
        }

        public User()
        {

        }

        [Required(ErrorMessage = "A name is required!")]
        [RegularExpression(@"^[a-zA-Z\-'\s]+$", ErrorMessage = "Your name must be valid!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "An email is required"),
         EmailAddress(ErrorMessage = "Your email address must be valid!")]
        public string Email { get { return email; } set { this.email = value; } }

        [Required(ErrorMessage = "A password is required")]
        [MinLength(6, ErrorMessage = "Your password needs to be at least 6 characters")]
        [RegularExpression(@"^(?=.*\d)[\S\s]+$", ErrorMessage = "Your password must contain a number!")]
        public string Password { get; set; }

        public string HashedPassword { get { return hashedPassword; } set { this.hashedPassword = value; } }

        public string Salt { get { return salt; } set { this.salt = value; } }

        public DateTime JoinDate { get { return joinDate; } set { this.joinDate = value; } }

        public int Id { get { return id; } set { id = value; } }

        public string JoinDateParsed()
        {
            string formattedDate = joinDate.ToString("d MMMM yyyy");
            return formattedDate;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
