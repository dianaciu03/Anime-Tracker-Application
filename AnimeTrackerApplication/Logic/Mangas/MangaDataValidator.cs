﻿using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Mangas
{
    public class MangaDataValidator
    {
        public MangaDataValidator()
        {

        }

        public bool IsNameValid(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("You need to provide a name!");
            else
                return true;
        }

        public bool IsCreatorValid(string creator)
        {
            if (String.IsNullOrEmpty(creator))
                throw new Exception("You need to provide a creator!");
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

        public bool IsNrChaptersValid(string nrchapters)
        {
            if (!String.IsNullOrEmpty(nrchapters))
            {
                try
                {
                    int nr = Convert.ToInt32(nrchapters);
                    if (nr >= 1)
                        return true;
                    else
                        throw new Exception("The number of chapters is not valid!");
                }
                catch (Exception)
                {
                    throw new Exception("The number of chapters is not valid!");
                }
            }
            else
                throw new Exception("You need to provide a number for chapters!");
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
                throw new Exception("You need to provide a number for rating!");
        }

        public bool IsYearValid(string year)
        {
            if (!String.IsNullOrEmpty(year))
            {
                try
                {
                    int nr = Convert.ToInt32(year);
                    if (nr >= 1850 && nr <= (DateTime.Now.Year + 10))
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

        public bool IsStatusValid(MangaStatus status)
        {
            if (!String.IsNullOrEmpty(status.ToString()))
            {
                if (Enum.IsDefined(typeof(MangaStatus), status))
                    return true;
                else
                    throw new Exception("You can't change the provided options!");
            }
            else
                throw new Exception("You need to provide a status!");
        }

        public bool IsValidImageUrl(string url)
        {
            try
            {
                string[] validExtensions = { ".jpg", ".jpeg", ".gif", ".png" };
                Uri uri = new Uri(url);

                string extension = Path.GetExtension(uri.AbsolutePath);

                if (string.IsNullOrEmpty(extension) || !validExtensions.Contains(extension.ToLower()))
                {
                    throw new Exception("The image link is not valid!");
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.ContentType.ToLower().StartsWith("image/");
                }
            }
            catch (Exception)
            {
                throw new Exception("The image link is not valid!");
            }
        }
    }
}
