using Logic.Contents;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Animes
{
    public class AnimeManager : IAnimeManager
    {
        private readonly IAnimeRepository _animeDataHandler;

        public AnimeManager(IAnimeRepository iAnime)
        {
            _animeDataHandler = iAnime;
        }

        public List<Anime> GetAllAnime()
        {
            return _animeDataHandler.GetAllAnime();
        }

        public Anime? GetAnimeById(int id)
        {
            return _animeDataHandler.GetAnimeById(id);
        }

        public int GetNrAnime()
        {
            return _animeDataHandler.GetNrAnime();
        }

        public void AddAnime(string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
        {
            Content anime = new Anime(name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
            _animeDataHandler.AddAnime((Anime)anime);
        }

        public void UpdateAnime(int id, string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
        {
            _animeDataHandler.UpdateAnime(id, name, studio, nrEpisodes, releaseYear, season, rating, description, imageURL);
        }

        public void DeleteAnime(int id)
        {
            _animeDataHandler.DeleteAnime(id);
        }

        //public string GiveCode()
        //{
        //    while (true)
        //    {
        //        Random r = new Random();
        //        int idNr = r.Next(1, 9999);
        //        string id = "A" + idNr;
        //        if (GetNrAnime() == 0)
        //        {
        //            return id;
        //        }
        //        else
        //        {
        //            if (!GetAllAnime().Select(x => x.Id).Contains(id))
        //            {
        //                return id;
        //            }
        //        }
        //    }
        //}
    }
}
