using Logic.Animes;
using Logic.Mangas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ManagerFactory
{
    public static class MangaManagerFactory
    {
        public static MangaManager CreateMangaManager(IMangaRepository mangaRepository)
        {
            return new MangaManager(mangaRepository);
        }
    }
}
