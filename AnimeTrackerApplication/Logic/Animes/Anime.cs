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

        public Anime(string id, string name, string description, double rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
            : base(id, name, description, rating, releaseYear, genres, imageURL)
        {
            this.season = season;
            this.nrEpisodes = nrEpisodes;
            this.studio = studio;
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
    }
}
