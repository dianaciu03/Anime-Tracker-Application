using Logic.Animes;
using Logic.Mangas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Characters
{
    public class CharacterManager : ICharacterManager
    {
        private readonly ICharacterRepository _characterDataHandler;
        private CharacterDataValidator cdv;

        public CharacterManager(ICharacterRepository iCharacterRepository)
        {
            _characterDataHandler = iCharacterRepository;
            cdv = new CharacterDataValidator();
        }

        public void AddCharacter(string name, string gender, string image, Anime anime, Manga manga)
        {
            try
            {
                if (cdv.IsNameValid(name) && cdv.IsValidImageUrl(image) && cdv.IsGenderValid(gender))
                {
                    Character character = new Character(name, gender, image);
                    if (anime != null)
                        character.FromAnime = anime;
                    if (manga != null)
                        character.FromManga = manga;

                    _characterDataHandler.AddCharacter(character);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void UpdateCharacter(int id, string name, string gender, string image, Anime anime, Manga manga, int nrLikes, int nrDislikes)
        {
            try
            {
                if (cdv.IsNameValid(name) && cdv.IsValidImageUrl(image) && cdv.IsGenderValid(gender))
                {
                    Character character = new Character(id, name, gender, image, nrLikes, nrDislikes);
                    if (anime != null)
                        character.FromAnime = anime;
                    if (manga != null)
                        character.FromManga = manga;

                    _characterDataHandler.UpdateCharacter(character);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Character> GetAllCharacters()
        {
            return _characterDataHandler.GetAllCharacters();
        }

        public void DeleteCharacter(int id)
        {
            _characterDataHandler.DeleteCharacter(id);
        }

        public Character GetCharacterById(int id)
        {
            return _characterDataHandler.GetCharacterById(id);
        }

        public List<Character> GetSearchedCharacters(string nameC, string genderC, List<Anime> animes, List<Manga> mangas)
        {
            return _characterDataHandler.GetSearchedCharacters(nameC, genderC, animes, mangas);
        }

        public List<Character> GetCharactersByName(string nameC)
        {
            return _characterDataHandler.GetCharactersByName(nameC);
        }
    }
}
