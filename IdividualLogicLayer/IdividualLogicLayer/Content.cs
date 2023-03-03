using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public abstract class Content
    {
        protected string name;
        protected string description;
        protected int id;
        protected double rating;
        protected int releaseYear;
        protected string imageURL;
        private bool isAdminOrMaintainer;
        protected List<Genre> genres = new List<Genre>();

        public Content(string name, string description, double rating, int releaseYear, List<Genre> genres, string imageURL)
        {
            this.name = name;
            this.description = description;
            this.rating = rating;
            this.releaseYear = releaseYear;
            this.genres = genres;
            this.imageURL = imageURL;
        }

        public bool IsAdmin { get { return isAdminOrMaintainer; } set { this.isAdminOrMaintainer = value; } }

        public string Name 
        { 
            get { return name; } 
            set 
            {
                if (isAdminOrMaintainer == true) //check for security level
                {
                    if (!string.IsNullOrEmpty(value)) //check for valid name
                    {
                        name = value;
                    }
                    else
                    {
                        throw new ArgumentException("You need to add a name!");
                    }
                }
                else
                {
                    throw new Exception("You do not have permission to modify the name!");
                }    
            }
        }

        public string Description 
        { 
            get { return description; }
            set
            {
                if (isAdminOrMaintainer == true) //check for security level
                {
                    if (!string.IsNullOrEmpty(value)) //check for valid name
                    {
                        description = value;
                    }
                    else
                    {
                        throw new ArgumentException("You need to add a description!");
                    }
                }
                else
                {
                    throw new Exception("You do not have permission to modify the name!");
                }
            }
        }

        public int Id 
        { 
            get { return id; }
            set
            {
                if (isAdminOrMaintainer == true) //check for security level
                {
                    id = value;
                }
                else
                {
                    throw new Exception("You do not have permission to modify the id!");
                }
            }
        }

        public double Rating 
        { 
            get { return rating; }
            set
            {
                if (isAdminOrMaintainer == true) //check for security level
                {
                    if (!string.IsNullOrEmpty(value.ToString())) //check for valid rating
                    {
                        if (value >= 1 && value <= 5) //check if it has a correct value
                        {
                            rating = value;
                        }
                        else
                        {
                            throw new Exception("The rating must be between 1 and 5!");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("You need to add a rating!");
                    }
                }
                else
                {
                    throw new Exception("You do not have permission to change the rating!");
                }
            }
        }

        public int ReleaseYear 
        { 
            get { return releaseYear; }
            set
            {
                if (isAdminOrMaintainer == true) //check for security level
                {
                    if (!string.IsNullOrEmpty(value.ToString())) //check for valid release year
                    {
                        releaseYear = value;
                    }
                    else
                    {
                        throw new ArgumentException("You need to add a release year!");
                    }
                }
                else
                {
                    throw new Exception("You do not have permission to modify the release year!");
                }
            }
        }

        public string ImageURL 
        { 
            get { return imageURL; }
            set
            {
                if (isAdminOrMaintainer == true) //check for security level
                {
                    imageURL = value;
                }
                else
                {
                    throw new Exception("You do not have permission to modify the image!");
                }
            }
        }

        public List<Genre> GetGenres()
        { 
            return genres;
        }

        public void AddGenre(Genre genre)
        {
            genres.Add(genre);
        }

        public virtual string GetInfoDisplay()
        {
            return $"{this.name} - Rating {this.rating}/5";
        }


    }
}
