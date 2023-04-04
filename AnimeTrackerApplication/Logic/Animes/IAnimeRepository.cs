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
        void DeleteAnime(string animeId);
        List<Anime> GetAllAnime();
        int GetNrAnime();
        void UpdateAnime(string id, string name, string studio, int nrEpisodes, int releaseYear, Season releaseSeason, decimal rating, string description, string imageURL);
    }
}