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
        protected int rating;
        protected int releaseYear;
        protected string imageURL;

        public Content(int id, string name, string description, int rating, int releaseYear, string imageURL)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.rating = rating;
            this.releaseYear = releaseYear;
            this.imageURL = imageURL;
        }

        public string Name { get { return name; } set { this.name = value; } }

        public string Description { get { return description; } set { this.description = value; } }

        public int Id { get { return id; } set { this.id = value; } }

        public int Rating { get { return rating; } set { this.rating = value; } }

        public int ReleaseYear { get { return releaseYear; } set { this.releaseYear = value; } }

        public string ImageURL { get { return imageURL; } set { this.imageURL = value; } }

        public virtual string GetInfoDisplay()
        {
            return $"{this.name} - Rating {this.rating}/5";
        }


    }
}
