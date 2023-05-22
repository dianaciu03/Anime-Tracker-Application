using Logic.Animes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class Profile
    {
        private int id;
        private string username;
        private List<CustomList> customLists = new List<CustomList>(); //customlist is an object

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

        public int Id { get { return id; } set { this.id = value; } }

        public void AddCustomList(CustomList list)
        {
            customLists.Add(list);
        }

        public List<CustomList> GetAllCustomLists()
        {
            return customLists;
        }

        public CustomList GetList(string name, string objtype)
        {
            foreach(CustomList l in customLists)
            {
                if (l.Name == name && l.ContentType == objtype)
                    return l;
            }
            return null;
        }

        public int CalculateTotalMinutesAnime()
        {
            CustomList watchedAnime = null;
            foreach(CustomList list in customLists)
            {
                if(list.Name == "Watched")
                {
                    watchedAnime = list;
                }
            }
            int totalMinutes = 0;
            foreach (Anime anime in watchedAnime.GetAllContent())
            {
                totalMinutes += (anime.NrEpisodes * 24);
            }
            return totalMinutes;
        }

        public int CalculateAnimeYears()
        {
            int totalMinutes = CalculateTotalMinutesAnime();
            int totalHours = totalMinutes/60;
            int totalDays = totalHours/24;
            int totalMonths = Convert.ToInt32(totalDays / 30.45);
            int years = totalMonths / 12;
            return years;
        }

        public int CalculateAnimeMonths()
        {
            int totalMinutes = CalculateTotalMinutesAnime();
            int totalHours = totalMinutes / 60;
            int totalDays = totalHours / 24;
            int totalMonths = Convert.ToInt32(totalDays / 30.45);
            int remainingMonths = totalMonths % 12;
            return remainingMonths;
        }

        public int CalculateAnimeDays()
        {
            int totalMinutes = CalculateTotalMinutesAnime();
            int totalHours = totalMinutes / 60;
            int totalDays = totalHours / 24;
            int remainingDays = totalDays % 30;
            return remainingDays;
        }

        public int CalculateAnimeHours()
        {
            int totalMinutes = CalculateTotalMinutesAnime();
            int totalHours = totalMinutes / 60;
            int remainingHours = totalHours % 24;
            return remainingHours;
        }

        public int CalculateAnimeMinutes()
        {
            int totalMinutes = CalculateTotalMinutesAnime();
            int remainingMinutes = totalMinutes % 60;
            return remainingMinutes;
        }
    }
}
