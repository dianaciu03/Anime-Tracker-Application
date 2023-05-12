using Logic.Contents;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Mangas
{
    public class Manga : Content
    {
        private MangaStatus status;
        private int nrChapters;
        private string creator;

        public Manga(int id, string name, string description, decimal rating, int releaseYear, string imageURL, MangaStatus status, int nrChapters, string creator, List<Genre> genres)
            : base(id, name, description, rating, releaseYear, genres, imageURL)
        {
            this.status = status;
            this.nrChapters = nrChapters;
            this.creator = creator;
        }

        public Manga(string name, string description, decimal rating, int releaseYear, string imageURL, MangaStatus status, int nrChapters, string creator, List<Genre> genres)
            : base(name, description, rating, releaseYear, genres, imageURL)
        {
            this.status = status;
            this.nrChapters = nrChapters;
            this.creator = creator;
        }

        public Manga()
        {

        }

        public MangaStatus Status { get { return status; } set { status = value; } }

        public int NrChapters { get { return nrChapters; } set { nrChapters = value; } }

        public string Creator { get { return creator; } set { creator = value; } }

        public override string ToString()
        {
            return $"{Name} - {nrChapters} chapters - Rating {Rating}/5";
        }

        public override string GetInfoDetailed()
        {
            string genresString = string.Join(", ", genres.Select(genre => genre.ToString()));
            string info = $"{Id}.{Name} - {nrChapters} chapters\nRelease date: {ReleaseYear}\nStatus: {Status}\nCreator: {creator}\nRating: {Rating}/5\n\nDescription:\n{Description}\n\nGenres: {genresString}\nImage URL: {ImageURL}";
            return info;
        }
    }
}
