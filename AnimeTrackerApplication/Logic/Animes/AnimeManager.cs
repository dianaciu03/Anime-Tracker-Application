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
        private AnimeDataValidator adv;

        public AnimeManager(IAnimeRepository iAnime)
        {
            _animeDataHandler = iAnime;
            adv = new AnimeDataValidator();
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
            try
            {
                if (adv.IsNameValid(name) && adv.IsStudioValid(studio) && adv.IsNrEpisodesValid(nrEpisodes.ToString()) && adv.IsYearValid(releaseYear.ToString()) && adv.IsSeasonValid(season) && adv.IsRatingValid(rating.ToString()) && adv.IsDescriptionValid(description) && adv.IsValidImageUrl(imageURL))
                {
                    Content anime = new Anime(name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
                    _animeDataHandler.AddAnime((Anime)anime);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void UpdateAnime(int id, string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres)
        {
            try
            {
                if (adv.IsNameValid(name) && adv.IsStudioValid(studio) && adv.IsNrEpisodesValid(nrEpisodes.ToString()) && adv.IsYearValid(releaseYear.ToString()) && adv.IsSeasonValid(season) && adv.IsRatingValid(rating.ToString()) && adv.IsDescriptionValid(description) && adv.IsValidImageUrl(imageURL))
                {
                    Content anime = new Anime(name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
                    _animeDataHandler.UpdateAnime((Anime)anime);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteAnime(int id)
        {
            _animeDataHandler.DeleteAnime(id);
        }

        public List<Anime> GetAnimeByName(string name)
        {
            return _animeDataHandler.GetAnimeByName(name);
        }

        public List<Anime> GetSearchedAnime(string nameA, string studioA, int nrEpFromA, int nrEpToA, string releaseYearA, string releaseSeasonA, string genreA, decimal ratingFromA, decimal ratingToA)
        {
            if (nrEpToA == 0)
                nrEpToA = 99999;
            if (ratingToA == 0)
                ratingToA = 5;
            return _animeDataHandler.GetSearchedAnime(nameA, studioA, nrEpFromA, nrEpToA, releaseYearA, releaseSeasonA, genreA, ratingFromA, ratingToA);
        }

    }
}
