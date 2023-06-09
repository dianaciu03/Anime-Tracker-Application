using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Animes
{
    public interface IAnimeRepository
    {
        void AddAnime(Anime anime);
        void DeleteAnime(int animeId);
        List<Anime> GetAllAnime(string sortBy, bool ascending);
        Anime? GetAnimeById(int animeId);
        int GetNrAnime();
        void UpdateAnime(Anime anime);
        List<Anime> GetAnimeByName(string name);
        List<Anime> GetSearchedAnime(string nameA, string studioA, int nrEpFromA, int nrEpToA, string releaseYearA, string releaseSeasonA, string genreA, decimal ratingFromA, decimal ratingToA);
        Dictionary<Anime, int> GetRecommendedAnime(int profileId);
    }
}
