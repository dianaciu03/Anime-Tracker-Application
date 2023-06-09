using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class ManagerFactory
    {
        public static AnimeManager CreateAnimeManager(IAnimeRepository animeRepository)
        {
            return new AnimeManager(animeRepository);
        }

        public static CharacterManager CreateCharacterManager(ICharacterRepository characterRepository)
        {
            return new CharacterManager(characterRepository);
        }

        public static MangaManager CreateMangaManager(IMangaRepository mangaRepository)
        {
            return new MangaManager(mangaRepository);
        }

        public static UserManager CreateUserManager(IUserRepository userRepository)
        {
            return new UserManager(userRepository);
        }

        public static ListManager CreateListManager(ICustomListRepository listRepository)
        {
            return new ListManager(listRepository);
        }

        public static ReviewManager CreateReviewManager(IReviewRepository reviewRepository)
        {
            return new ReviewManager(reviewRepository);
        }
    }
}
