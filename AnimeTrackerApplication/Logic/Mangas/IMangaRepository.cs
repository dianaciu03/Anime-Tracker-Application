using Logic.Enums;
using Logic.Mangas;

namespace Logic.Mangas
{
    public interface IMangaRepository
    {
        void AddManga(Manga manga);
        void DeleteManga(int mangaId);
        List<Manga> GetAllManga(string sortBy, bool ascending);
        Manga? GetMangaById(int mangaId);
        List<Manga> GetMangaByName(string name);
        int GetNrManga();
        void UpdateManga(Manga manga);
    }
}