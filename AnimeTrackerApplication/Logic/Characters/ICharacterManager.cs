﻿using Logic.Animes;
using Logic.Mangas;

namespace Logic.Characters
{
    public interface ICharacterManager
    {
        void AddCharacter(string name, string gender, string image, Anime anime, Manga manga);
        void DeleteCharacter(int id);
        List<Character> GetAllCharacters();
        void UpdateCharacter(string name, string gender, string image, Anime anime, Manga manga);
    }
}