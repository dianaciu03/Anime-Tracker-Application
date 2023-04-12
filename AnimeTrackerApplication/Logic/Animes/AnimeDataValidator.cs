using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Animes
{
    public class AnimeDataValidator
    {
        public AnimeDataValidator()
        {

        }

        public bool IsNameValid(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("You need to provide a name!");
            else
                return true;
        }

        public bool IsStudioValid(string studio)
        {
            if (String.IsNullOrEmpty(studio))
                throw new Exception("You need to provide a studio!");
            else
                return true;
        }

        public bool IsDescriptionValid(string description)
        {
            if (String.IsNullOrEmpty(description))
                throw new Exception("You need to provide a description!");
            else
                return true;
        }

        public bool IsNrEpisodesValid(string nrEpisodes)
        {
            if(!String.IsNullOrEmpty(nrEpisodes))
            {
                try
                {
                    int nr = Convert.ToInt32(nrEpisodes);
                    if (nr >= 1)
                        return true;
                    else
                        throw new Exception("The number of episodes is not valid!");
                }
                catch(Exception)
                {
                    throw new Exception("The number of episodes is not valid!");
                }
            }
            else
                throw new Exception("You need to provide a number for episodes!");
        }

        public bool IsRatingValid(string rating)
        {
            if (!String.IsNullOrEmpty(rating))
            {
                try
                {
                    decimal nr = Convert.ToDecimal(rating);
                    if (nr >= 1 && nr <= 5)
                        return true;
                    else
                        throw new Exception("The rating must be between 1 and 5!");
                }
                catch (Exception)
                {
                    throw new Exception("The rating is not valid number!");
                }
            }
            else
                throw new Exception("You need to provide a number for episodes!");
        }

        public bool IsYearValid(string year)
        {
            if (!String.IsNullOrEmpty(year))
            {
                try
                {
                    int nr = Convert.ToInt32(year);
                    if (nr >= 1900 && nr <= (DateTime.Now.Year + 10))
                        return true;
                    else
                        throw new Exception("The release year is not valid!");
                }
                catch (Exception)
                {
                    throw new Exception("The release year is not valid!");
                }
            }
            else
                throw new Exception("You need to provide a release year!");
        }

        public bool IsSeasonValid(Season season)
        {
            if (!String.IsNullOrEmpty(season.ToString()))
            {
                if (Enum.IsDefined(typeof(Season), season))
                    return true;
                else
                    throw new Exception("You can't change the provided options!");
            }
            else
                throw new Exception("You need to provide a season!");
        }

        public bool IsPathValid(string path)
        {
            //how to validate url keywords: ping, http request
            if (String.IsNullOrEmpty(path))
                throw new Exception("You need to provide an URL from an online image!");
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
