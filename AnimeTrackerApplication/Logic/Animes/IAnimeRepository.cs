﻿using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Animes
{
    public interface IAnimeRepository
    {
        void AddAnime(Anime anime);
        void DeleteAnime(int animeId);
        List<Anime> GetAllAnime();
        Anime? GetAnimeById(int animeId);
        int GetNrAnime();
        void UpdateAnime(Anime anime);
    }
}
