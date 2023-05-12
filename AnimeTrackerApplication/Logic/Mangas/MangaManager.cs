using Logic.Animes;
using Logic.Contents;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Logic.Mangas
{
    public class MangaManager : IMangaManager
    {
        private readonly IMangaRepository _mangaDataHandler;
        private MangaDataValidator mdv;

        public MangaManager(IMangaRepository iManga)
        {
            _mangaDataHandler = iManga;
            mdv = new MangaDataValidator();
        }

        public List<Manga> GetAllManga(string sortBy, bool ascending)
        {
            return _mangaDataHandler.GetAllManga(sortBy, ascending);
        }

        public Manga? GetMangaById(int id)
        {
            return _mangaDataHandler.GetMangaById(id);
        }

        public int GetNrManga()
        {
            return _mangaDataHandler.GetNrManga();
        }

        public void AddManga(string name, string description, decimal rating, int releaseYear, string imageURL, MangaStatus status, int nrChapters, string creator, List<Genre> genres)
        {
            try
            {
                if (mdv.IsNameValid(name) && mdv.IsCreatorValid(creator) && mdv.IsNrChaptersValid(nrChapters.ToString()) && mdv.IsYearValid(releaseYear.ToString()) && mdv.IsStatusValid(status) && mdv.IsRatingValid(rating.ToString()) && mdv.IsDescriptionValid(description) && mdv.IsValidImageUrl(imageURL))
                {
                    Content manga = new Manga(name, description, rating, releaseYear, imageURL, status, nrChapters, creator, genres);
                    _mangaDataHandler.AddManga((Manga)manga);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateManga(int id, string name, string creator, int nrChapters, int releaseYear, MangaStatus status, decimal rating, string description, string imageURL, List<Genre> genres)
        {
            try
            {
                if (mdv.IsNameValid(name) && mdv.IsCreatorValid(creator) && mdv.IsNrChaptersValid(nrChapters.ToString()) && mdv.IsYearValid(releaseYear.ToString()) && mdv.IsStatusValid(status) && mdv.IsRatingValid(rating.ToString()) && mdv.IsDescriptionValid(description) && mdv.IsValidImageUrl(imageURL))
                {
                    Content manga = new Manga(id, name, description, rating, releaseYear, imageURL, status, nrChapters, creator, genres);
                    _mangaDataHandler.UpdateManga((Manga)manga);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteManga(int id)
        {
            _mangaDataHandler.DeleteManga(id);
        }

        public List<Manga> GetMangaByName(string name)
        {
            return _mangaDataHandler.GetMangaByName(name);
        }

    }   
}
