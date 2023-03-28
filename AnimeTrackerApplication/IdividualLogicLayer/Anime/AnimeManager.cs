using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IdividualLogicLayer
{
    public class AnimeManager : ContentManager
    {
        private readonly IAnime _animeDataHandler;
        List<Anime> animes;

        public AnimeManager(IAnime _animeDataHandler) : base()
        {
            animes = new List<Anime>();
            this._animeDataHandler = _animeDataHandler;
        }

        public List<Anime> GetAllAnime()
        {
            return animes = _animeDataHandler.GetAllAnime();
        }

        public void AddAnime(string name, string description, double rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
        {
            Anime anime = new Anime(GiveId(), name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
            _animeDataHandler.AddAnime(anime);
        }

        public void UpdateAnime(string id, string name, string description, double rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
        {
            _animeDataHandler.UpdateAnime(id, name, studio, nrEpisodes, releaseYear, season, rating, description, imageURL);
        }

        public void DeleteAnime(string id)
        {
            _animeDataHandler.DeleteAnime(id);
        }

        public override string GiveId()
        {
            while (true)
            {
                Random r = new Random();
                int idNr = r.Next(1, 9999);
                string id = "X" + idNr;
                if (!animes.Select(x => x.Id).Contains(id))
                {
                    return id;
                }
            }
        }
    }
}
