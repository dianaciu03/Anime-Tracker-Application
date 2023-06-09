using Logic.Characters;
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
        private string contentType;
        private List<object> content = new List<object>();

        public CustomList(string name, string type)
        {
            this.name = name;
            this.id = 0;
            this.contentType = type;
        }

        public CustomList(int id, string name, string type)
        {
            this.name = name;
            this.id = id;
            this.contentType = type;
        }

        public CustomList()
        {

        }

        public string Name { get { return name; } set { name = value; } }

        public string ContentType { get { return contentType; } set { contentType = value; } }

        public int Id { get { return id; } }

        public void AddContent(object objectContent)
        {
            content.Add(objectContent);
        }

        public bool IsContaining(object contentObject)
        {
            Character character = null;
            if(contentObject is Character)
            {
                character = (Character)contentObject;
            }
            if(contentType == "Character")
            {
                foreach(Character charact in content)
                {
                    if(charact.Id == character.Id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<object> GetAllContent()
        {
            return content;
        }
    }
}
