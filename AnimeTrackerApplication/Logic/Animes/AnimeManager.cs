using Logic.Contents;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logic.Animes
{
    public class AnimeManager : IAnimeManager
    {
        private readonly IAnimeRepository _animeDataHandler;

        public AnimeManager(IAnimeRepository iAnime)
        {
            _animeDataHandler = iAnime;
        }

        public List<Anime> GetAllAnime(string sortBy, bool ascending)
        {
            return _animeDataHandler.GetAllAnime(sortBy, ascending);
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
            Content anime = new Anime(id, name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
            _animeDataHandler.UpdateAnime((Anime)anime);
        }

        public void DeleteAnime(int id)
        {
            _animeDataHandler.DeleteAnime(id);
        }

        public List<Anime> GetAnimeByName(string name)
        {
            return _animeDataHandler.GetAnimeByName(name);
        }

    }
}
