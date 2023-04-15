﻿using Logic.Animes;
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

        public CharacterManager(ICharacterRepository iCharacterRepository)
        {
            _characterDataHandler = iCharacterRepository;
        }

        public void AddCharacter(string name, string gender, string image, Anime anime, Manga manga)
        {
            Character character = new Character(name, gender, image);
            if (anime != null)
                character.FromAnime = anime;
            if (manga != null)
                character.FromManga = manga;

            _characterDataHandler.AddCharacter(character);
        }

        public void UpdateCharacter(string name, string gender, string image, Anime anime, Manga manga)
        {
            Character character = new Character(name, gender, image);
            if (anime != null)
                character.FromAnime = anime;
            if (manga != null)
                character.FromManga = manga;

            _characterDataHandler.UpdateCharacter(character);
        }

        public List<Character> GetAllCharacters()
        {
            return _characterDataHandler.GetAllCharacters();
        }

        public void DeleteCharacter(int id)
        {
            _characterDataHandler.DeleteCharacter(id);
        }
    }
}
