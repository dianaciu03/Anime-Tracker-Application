using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.Users
{
    public class UserDataValidator
    {
        public UserDataValidator()
        {

        }

        public bool IsNameValid(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("You need to provide a studio!");

            // Regular expression pattern to match letters, spaces, dashes, and apostrophes
            string pattern = @"^[a-zA-Z\s'-]+$";

            // Check if the name matches the pattern
            if (Regex.IsMatch(name, pattern) == false)
                throw new Exception("You need to provide a valid name!");
            else
                return true;
        }

        public bool IsEmailValid(string email)
        {
            if (String.IsNullOrEmpty(email))
                throw new Exception("You need to provide an email!");
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                throw new Exception("You need to provide a valid email!");
            }
        }

        public bool IsPasswordValid(string password)
        {
            if (String.IsNullOrEmpty(password))
                throw new Exception("You need to provide a password!");

            if (password.Length < 6)
                throw new Exception("The password must have at least 6 characters!");

            // Check if password contains at least one digit
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            throw new Exception("The password must include numbers!");
        }
    }
}
