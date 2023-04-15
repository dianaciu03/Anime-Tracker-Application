using Logic.Contents;
using Logic.Enums;
using System;
using System.Collections.Generic;
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
            Content anime = new Anime(id, name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
            _animeDataHandler.UpdateAnime((Anime)anime);
        }

        public void DeleteAnime(int id)
        {
            _animeDataHandler.DeleteAnime(id);
        }

        //public List<Anime> SortAnime(int option)
        //{
        //    switch(option)
        //    {
        //        case 1:
        //            return GetAllAnime().OrderBy(x => x.Name).ToList();

        //        case 2:
        //            return GetAllAnime().OrderByDescending(x => x.Name).ToList();

        //        case 3:
        //            return GetAllAnime().OrderBy(x => x.Studio).ThenBy(x => x.Name).ToList();

        //        case 4:
        //            return GetAllAnime().OrderByDescending(x => x.Studio).ThenBy(x => x.Name).ToList();

        //        case 5:
        //            return GetAllAnime().OrderBy(x => x.ReleaseYear).ThenBy(x => x.Name).ToList();

        //        case 6:
        //            return GetAllAnime().OrderByDescending(x => x.ReleaseYear).ThenBy(x => x.Name).ToList();

        //        case 7:
        //            return GetAllAnime().OrderBy(x => x.Rating).ThenBy(x => x.Name).ToList();

        //        case 8:
        //            return GetAllAnime().OrderByDescending(x => x.Rating).ThenBy(x => x.Name).ToList();

        //        default:
        //            return GetAllAnime().OrderBy(x => x.Name).ToList();
        //    }
        //}

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
