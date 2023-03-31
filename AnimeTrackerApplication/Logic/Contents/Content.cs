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

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string Id { get; }

        public double Rating { get; set; }

        public int ReleaseYear { get; set; }
        
        public string ImageURL { get; set; }

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
