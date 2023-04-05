using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.RepositoryFactory
{
    public static class AnimeRepositoryFactory
    {
        public static AnimeRepository CreateAnimeRepository()
        {
            return new AnimeRepository();
        }
    }
}
