﻿using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;

namespace Logic.Characters
{
    public interface ICharacterRepository
    {
        void AddCharacter(Character character);
        void DeleteCharacter(int characterId);
        List<Character> GetAllCharacters();
        void UpdateCharacter(Character character);
        Character? GetCharacterById(int id);
        List<Character> GetSearchedCharacters(string nameC, string genderC, List<Anime> animes, List<Manga> mangas);
        List<Character> GetCharactersByName(string nameC);
        void UpdateCharacterLikes(int characterId, int nrLikes);
        void UpdateCharacterDislikes(int characterId, int nrDislikes);
    }
}