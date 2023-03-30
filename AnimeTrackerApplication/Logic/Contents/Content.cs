using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contents
{
    public abstract class Content
    {
        protected string name;
        protected string description;
        protected string id;
        protected double rating;
        protected int releaseYear;
        protected string imageURL;
        protected List<Genre> genres = new List<Genre>();

        public Content(string id, string name, string description, double rating, int releaseYear, List<Genre> genres, string imageURL)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.rating = rating;
            this.releaseYear = releaseYear;
            this.genres = genres;
            this.imageURL = imageURL;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value)) //check for valid name
                    name = value;
                else
                    throw new Exception("You need to add a name!");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value)) //check for valid description
                    description = value;
                else
                    throw new Exception("You need to add a description!");
            }
        }

        public string Id
        {
            get { return id; }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                if (!String.IsNullOrEmpty(value.ToString())) //check for valid rating
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
                    throw new Exception("You need to add a rating!");
                }
            }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                if (!String.IsNullOrEmpty(value.ToString())) //check for valid release year
                {
                    if (value > 1900 && value < (DateTime.Now.Year + 10))
                    {
                        releaseYear = value;
                    }
                    else
                    {
                        throw new Exception("Release year is invalid!");
                    }

                }
                else
                {
                    throw new Exception("You need to add a release year!");
                }
            }
        }

        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }

        public List<Genre> GetGenres()
        {
            return genres;
        }

        public void AddGenre(Genre genre)
        {
            genres.Add(genre);
        }

        public virtual string GetInfoDetailed()
        {
            string genresString = string.Join(", ", genres.Select(genre => genre.ToString()));
            string info = $"{this.id}.{this.name}\nRelease year: {this.releaseYear}\nRating: {this.rating}/5\n\nDescription:\n{this.description}\n\nGenres: {genresString}\nImage URL: {this.imageURL}";
            return info;
        }

        public override string ToString()
        {
            return $"{this.name} - Rating {this.rating}/5";
        }
    }
}
