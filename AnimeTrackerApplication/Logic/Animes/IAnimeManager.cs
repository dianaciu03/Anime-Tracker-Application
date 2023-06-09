using Logic.Enums;

namespace Logic.Animes
{
    public interface IAnimeManager
    {
        void AddAnime(string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres);
        void DeleteAnime(int id);
        List<Anime> GetAllAnime(string sortBy, bool ascending);
        Anime? GetAnimeById(int id);
        List<Anime> GetAnimeByName(string name);
        int GetNrAnime();
        void UpdateAnime(int id, string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres);
        List<Anime> GetSearchedAnime(string nameA, string studioA, int nrEpFromA, int nrEpToA, string releaseYearA, string releaseSeasonA, string genreA, decimal ratingFromA, decimal ratingToA);
        Dictionary<Anime, int> GetRecommendedAnime(int profileId);
        int CalculateMatchPercent(int nrGenresAnime, int nrGenresProfile);
    }
}