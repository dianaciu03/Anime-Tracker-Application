using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public class Manga : Content
    {
        private string creator;
        private int nrChapters;
        private MangaStatus mangaStatus;

        public Manga(string name, string description, double rating, int releaseYear, string imageURL, MangaStatus mangaStatus, int nrChapters, string creator, List<Genre> genres)
            : base(name, description, rating, releaseYear, genres, imageURL)
        {
            this.creator = creator;
            this.nrChapters = nrChapters;
            this.mangaStatus = mangaStatus;
        }

        public string Creator 
        { 
            get { return creator; } 
            set { creator = value; }
        }

        public int NrChapters
        {
            get { return nrChapters; }
            set { nrChapters = value; }
        }

        public MangaStatus MangaStatusManga
        {
            get { return mangaStatus; }
            set { mangaStatus = value; }
        }
    }
}
