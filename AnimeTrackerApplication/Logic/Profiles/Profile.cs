using Logic.Animes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class Profile
    {
        private int id;
        private string username;
        private List<CustomList> customLists = new List<CustomList>();

        public Profile(string username)
        {
            this.username = username;
            customLists.Add(new CustomList("Watched", "Anime"));
            customLists.Add(new CustomList("Want to watch", "Anime"));
            customLists.Add(new CustomList("Read", "Manga"));
            customLists.Add(new CustomList("Want to read", "Manga"));
            customLists.Add(new CustomList("Favourite characters", "Character"));
            customLists.Add(new CustomList("Disliked characters", "Character"));
        }

        public Profile(int id, string username)
        {
            this.id = id;
            this.username = username;
        }

        public Profile()
        {

        }

        [Required(ErrorMessage = "A username is required")]
        public string Username { get { return username; } set { this.username = value; } }

        public void AddCustomList(CustomList list)
        {
            customLists.Add(list);
        }

        public List<CustomList> GetAllCustomLists()
        {
            return customLists;
        }

        //public CustomList GetWatchedAnimeCustomList(int profileId, string listTitle)
        //{
        //    return 
        //}

        public int CalculateTotalMinutesAnime(CustomList watchedAnime)
        {
            int totalMinutes = 0;
            foreach (Anime anime in watchedAnime.GetAllContent())
            {
                totalMinutes += (anime.NrEpisodes * 24);
            }
            return totalMinutes;
        }

        public int CalculateAnimeYears(int totalMinutes)
        {
            int totalHours = totalMinutes/60;
            int totalDays = totalHours/24;
            int totalMonths = Convert.ToInt32(totalDays / 30.45);
            int years = totalMonths / 12;
            return years;
        }

        public int CalculateAnimeMonths(int totalMinutes)
        {
            int totalHours = totalMinutes / 60;
            int totalDays = totalHours / 24;
            int totalMonths = Convert.ToInt32(totalDays / 30.45);
            int remainingMonths = totalMonths % 12;
            return remainingMonths;
        }

        public int CalculateAnimeDays(int totalMinutes)
        {
            int totalHours = totalMinutes / 60;
            int totalDays = totalHours / 24;
            int remainingDays = totalDays % 30;
            return remainingDays;
        }

        public int CalculateAnimeHours(int totalMinutes)
        {
            int totalHours = totalMinutes / 60;
            int remainingHours = totalHours % 24;
            return remainingHours;
        }

        public int CalculateAnimeMinutes(int totalMinutes)
        {
            int remainingMinutes = totalMinutes % 60;
            return remainingMinutes;
        }
    }
}
