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
            customLists.Add(new CustomList("Watched"));
            customLists.Add(new CustomList("Want to watch"));
            customLists.Add(new CustomList("Read"));
            customLists.Add(new CustomList("Want to read"));
            customLists.Add(new CustomList("Favourite characters"));
            customLists.Add(new CustomList("Disliked characters"));
        }

        public Profile(int id, string username, List<CustomList> customLists)
        {
            this.id = id;
            this.username = username;
            this.customLists = customLists;
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
    }
}
