using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.RepositoryFactory
{
    public static class MangaRepositoryFactory
    {
        public static MangaRepository CreateMangaRepository()
        {
            return new MangaRepository();
        }
    }
}
