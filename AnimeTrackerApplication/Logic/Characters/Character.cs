using Logic.Animes;
using Logic.Enums;
using Logic.Mangas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Characters
{
    public class Character
    {
        private int id;
        private string name;
        private string image;
        private string gender;
        private Anime anime;
        private Manga manga;
        private int nrLikes;
        private int nrDislikes;
        private int animeId;
        private int mangaId;

        public Character(int id, string name, string gender, string image, int nrLikes, int nrDislikes)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.gender = gender;
            this.nrLikes = nrLikes;
            this.nrDislikes = nrDislikes;
            this.animeId = 0;
            this.mangaId = 0;
        }

        public Character(string name, string gender, string image)
        {
            this.name = name;
            this.image = image;
            this.gender = gender;
            this.nrLikes = 0;
            this.nrDislikes = 0;
            this.animeId = 0;
            this.mangaId = 0;
        }

        public string Name { get { return name; } set { name = value; } }

        public int Id { get { return id; } set { id = value; } }

        public string Gender { get { return gender; } set { gender = value; } }

        public string Image { get { return image; } set { image = value; } }

        public int AnimeId { get { return animeId; } set { animeId = value; } }

        public int MangaId { get { return mangaId; } set { mangaId = value; } }

        public Anime FromAnime { get { return anime; } set { anime = value; } }

        public Manga FromManga { get { return manga; } set { manga = value; } }

        public int NrLikes { get { return nrLikes; } set { nrLikes = value; } }

        public int NrDislikes { get { return nrDislikes; } set { nrDislikes = value; } }

        public void IncreaseLikes()
        {
            nrLikes++;
        }

        public void IncreaseDislikes()
        {
            nrDislikes++;
        }

        public void DecreaseLikes()
        {
            nrLikes--;
        }

        public void DecreaseDislikes()
        {
            nrDislikes--;
        }

        public override string ToString()
        {
            return $"{Name} - Anime: {anime.Name}/ Manga - {manga.Name}";
        }

        public string GetInfoDetailed()
        {
            string info = $"{Id}.{Name} - Anime: {anime.Name}/ Manga - {manga.Name}\nNr likes: {nrLikes}\nNr dislikes: {nrDislikes}";
            return info;
        }
    }
}
