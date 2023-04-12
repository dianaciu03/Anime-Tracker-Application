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

        public bool IsValidImageUrl(string url)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".gif", ".png" };
            string extension = Path.GetExtension(url);

            if (!validExtensions.Contains(extension.ToLower()))
                return false;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.ContentType.ToLower().StartsWith("image/");
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
