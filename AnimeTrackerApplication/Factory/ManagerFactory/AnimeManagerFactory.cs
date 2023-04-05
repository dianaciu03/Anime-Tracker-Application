using Logic.Animes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ManagerFactory
{
    public static class AnimeManagerFactory
    {
        public static AnimeManager CreateAnimeManager(IAnimeRepository animeRepository)
        {
            return new AnimeManager(animeRepository);
        }
    }
}
