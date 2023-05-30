using Logic.Animes;
using Logic.Mangas;

namespace Logic.Characters
{
    public interface ICharacterManager
    {
        void AddCharacter(string name, string gender, string image, Anime anime, Manga manga);
        void DeleteCharacter(int id);
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        void UpdateCharacter(int id, string name, string gender, string image, Anime anime, Manga manga, int nrLikes, int nrDislikes);
        List<Character> GetSearchedCharacters(string nameC, string genderC, List<Anime> animes, List<Manga> mangas);
    }
}