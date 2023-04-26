using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class CustomList
    {
        private int id;
        private string name;
        private List<object> content;

        public CustomList(string name)
        {
            this.name = name;
            this.id = 0;
            content = new List<object>();
        }

        public string Name { get { return name; } set { name = value; } }

        public int Id { get { return id; } }

        public List<object> Content { get { return content; } }
    }
}
