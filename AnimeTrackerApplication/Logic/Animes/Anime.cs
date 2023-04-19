using Logic.Contents;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Animes
{
    public class Anime : Content
    {
        private Season season;
        private int nrEpisodes;
        private string studio;

        public Anime(int id, string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
            : base(id, name, description, rating, releaseYear, genres, imageURL)
        {
            this.season = season;
            this.nrEpisodes = nrEpisodes;
            this.studio = studio;
        }

        public Anime(string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
            : base(name, description, rating, releaseYear, genres, imageURL)
        {
            this.season = season;
            this.nrEpisodes = nrEpisodes;
            this.studio = studio;
        }

        public Anime() : base()
        {

        }

        public Season SeasonAnime { get { return season; } set { season = value; } }

        public int NrEpisodes { get { return nrEpisodes; } set { nrEpisodes = value; } }

        public string Studio { get { return studio; } set { studio = value; } }

        public override string ToString()
        {
            return $"{Name} - {nrEpisodes} episodes - Rating {Rating}/5";
        }

        public override string GetInfoDetailed()
        {
            string genresString = string.Join(", ", genres.Select(genre => genre.ToString()));
            string info = $"{Id}.{Name} - {nrEpisodes} episodes\nRelease date: {season}, {ReleaseYear}\nStudio: {studio}\nRating: {Rating}/5\n\nDescription:\n{Description}\n\nGenres: {genresString}\nImage URL: {ImageURL}";
            return info;
        }

        //int IComparableAnime.CompareTo(object? obj, int number)
        //{
        //    Anime other = obj as Anime;
        //    if (other == null)
        //    {
        //        throw new Exception("There was nothing to sort!");
        //    }
        //    int comparison;
        //    int option = number;

        //    switch (option)
        //    {
        //        case 1:
        //            return other.Name.CompareTo(this.Name);

        //        case 2:
        //            return this.Name.CompareTo(other.Name);

        //        case 3:
        //            return other.Studio.CompareTo(this.Studio);

        //        case 4:
        //            return this.Studio.CompareTo(other.Studio);

        //        case 5:
        //            if (other.ReleaseYear > this.ReleaseYear)
        //                comparison = -1;
        //            else if (other.ReleaseYear < this.ReleaseYear)
        //                comparison = 1;
        //            else
        //                comparison = 0;

        //            if (comparison != 0)
        //                return comparison;
        //            else
        //                return other.Name.CompareTo(this.Name);

        //        case 6:
        //            if (other.ReleaseYear < this.ReleaseYear)
        //                comparison = -1;
        //            else if (other.ReleaseYear > this.ReleaseYear)
        //                comparison = 1;
        //            else
        //                comparison = 0;

        //            if (comparison != 0)
        //                return comparison;
        //            else
        //                return other.Name.CompareTo(this.Name);

        //        case 7:
        //            if (other.Rating > this.Rating)
        //                comparison = -1;
        //            else if (other.Rating < this.Rating)
        //                comparison = 1;
        //            else
        //                comparison = 0;

        //            if (comparison != 0)
        //                return comparison;
        //            else
        //                return other.Name.CompareTo(this.Name);

        //        case 8:
        //            if (other.Rating < this.Rating)
        //                comparison = -1;
        //            else if (other.Rating > this.Rating)
        //                comparison = 1;
        //            else
        //                comparison = 0;

        //            if (comparison != 0)
        //                return comparison;
        //            else
        //                return other.Name.CompareTo(this.Name);

        //        default:
        //            return other.Name.CompareTo(this.Name);
        //    }

        //}

        //public int CompareTo(object? obj)
        //{
        //    if (obj == null) return 1;

        //    if (obj is Anime other)
        //    {
        //        // Call the private overloaded CompareTo method with default comparison option 1
        //        return CompareTo(other, 1);
        //    }

        //    throw new ArgumentException("Object is not an Anime.");
        //}
    }
}
