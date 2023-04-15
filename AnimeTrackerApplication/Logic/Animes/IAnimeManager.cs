using Logic.Enums;

namespace Logic.Animes
{
    public interface IAnimeManager
    {
        void AddAnime(string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres);
        void DeleteAnime(int id);
        List<Anime> GetAllAnime();
        Anime? GetAnimeById(int id);
        List<Anime> GetAnimeByName(string name);
        int GetNrAnime();
        void UpdateAnime(int id, string name, string description, decimal rating, int releaseYear, string imageURL, Season season, int nrEpisodes, string studio, List<Genre> genres);
    }
}