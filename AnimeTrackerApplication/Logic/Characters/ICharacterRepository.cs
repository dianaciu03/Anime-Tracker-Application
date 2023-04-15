using Logic.Characters;

namespace Logic.Characters
{
    public interface ICharacterRepository
    {
        void AddCharacter(Character character);
        void DeleteCharacter(int characterId);
        List<Character> GetAllCharacters();
        void UpdateCharacter(Character character);
    }
}