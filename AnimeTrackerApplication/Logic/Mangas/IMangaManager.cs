using Logic.Enums;

namespace Logic.Mangas
{
    public interface IMangaManager
    {
        void AddManga(string name, string description, decimal rating, int releaseYear, string imageURL, MangaStatus status, int nrChapters, string creator, List<Genre> genres);
        void DeleteManga(int id);
        List<Manga> GetAllManga();
        Manga? GetMangaById(int id);
        int GetNrManga();
        void UpdateManga(int id, string name, string creator, int nrChapters, int releaseYear, MangaStatus status, decimal rating, string description, string imageURL, List<Genre> genres);
    }
}