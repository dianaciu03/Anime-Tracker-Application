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
        void UpdateManga(Manga manga);
    }
}