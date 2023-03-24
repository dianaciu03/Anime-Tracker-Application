using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public class Anime : Content
    {
        private Season season;
        private int nrEpisodes;
        private string studio;

        public Anime(string name, string description, double rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
            : base(name, description, rating, releaseYear, genres, imageURL)
        {
            this.season = season;
            this.nrEpisodes = nrEpisodes;
            this.studio = studio;
        }

        public Season SeasonAnime { get { return season; } set { this.season = value; } }

        public int NrEpisodes { get { return nrEpisodes; } set { this.nrEpisodes = value; } }

        public string Studio { get { return studio; } set { this.studio = value; } }

        public override string ToString()
        {
            return $"{Name} - {this.nrEpisodes} episodes - Rating {Rating}/5";
        }

        public override string GetInfoDetailed()
        {
            string genresString = string.Join(", ", genres.Select(genre => genre.ToString()));
            string info = $"{Id}.{Name} - {this.nrEpisodes} episodes\nRelease date: {this.season}, {ReleaseYear}\nStudio: {this.studio}\nRating: {Rating}/5\n\nDescription:\n{Description}\n\nGenres: {genresString}\nImage URL: {ImageURL}";
            return info;
        }
    }
}
