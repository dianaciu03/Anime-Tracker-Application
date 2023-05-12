using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class RepositoryFactory
    {
        public static AnimeRepository CreateAnimeRepository()
        {
            return new AnimeRepository();
        }

        public static CharacterRepository CreateCharacterRepository()
        {
            return new CharacterRepository();
        }

        public static MangaRepository CreateMangaRepository()
        {
            return new MangaRepository();
        }

        public static UserRepository CreateUserRepository()
        {
            return new UserRepository();
        }
    }
}
