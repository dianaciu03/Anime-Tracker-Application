using Logic.Enums;
using Logic.Mangas;

namespace Logic.Mangas
{
    public interface IMangaRepository
    {
        void AddManga(Manga manga);
        void DeleteManga(int mangaId);
        List<Manga> GetAllManga();
        Manga? GetMangaById(int mangaId);
        int GetNrManga();
        void UpdateManga(int id, string name, string creator, int nrChapters, int releaseYear, MangaStatus status, decimal rating, string description, string imageURL, List<Genre> genres);
    }
}