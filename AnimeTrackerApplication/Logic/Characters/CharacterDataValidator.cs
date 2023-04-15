using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Characters
{
    public class CharacterDataValidator
    {
        public CharacterDataValidator()
        {

        }

        public bool IsNameValid(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("You need to provide a name!");
            else
                return true;
        }

        public bool IsGenderValid(string gender)
        {
            if (String.IsNullOrEmpty(gender))
                throw new Exception("You need to provide a gender!");
            else
                return true;
        }

        public bool IsValidImageUrl(string url)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".gif", ".png" };
            Uri uri = new Uri(url);

            string extension = Path.GetExtension(uri.AbsolutePath);

            if (string.IsNullOrEmpty(extension) || !validExtensions.Contains(extension.ToLower()))
            {
                throw new Exception("The image link is not valid!");
            }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.ContentType.ToLower().StartsWith("image/");
                }
            }
            catch(Exception)
            {
                throw new Exception("The image link is not valid!");
            }
        }
    }
}
