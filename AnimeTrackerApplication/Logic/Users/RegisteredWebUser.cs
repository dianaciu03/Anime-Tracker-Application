using Logic.Enums;
using Logic.Profiles;
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
        private Profile profile;

        public RegisteredWebUser(string name, string email, string hashedPassword, DateTime joinDate, string salt, Profile profile) : base(name, email, hashedPassword, joinDate, salt)
        {
            this.profile = profile;
        }

        public RegisteredWebUser(int id, string name, string email, string hashedPassword, DateTime joinDate, string salt, Profile profile) : base(id, name, email, hashedPassword, joinDate, salt)
        {
            this.profile = profile;
        }

        public RegisteredWebUser(int id, string name, string email, string hashedPassword, DateTime joinDate, string salt) : base(id, name, email, hashedPassword, joinDate, salt)
        {

        }

        public RegisteredWebUser()
        {

        }

        public Profile Profile { get { return profile; } set { profile = value; } }

        public override string ToString()
        {
            return $"{profile.Username}";
        }
    }
}
