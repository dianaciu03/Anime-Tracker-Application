using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contents
{
    public abstract class ContentManager
    {

        public ContentManager()
        {

        }

        public virtual string GiveId()
        {
            while (true)
            {
                Random r = new Random();
                int idNr = r.Next(1, 9999);
                string id = "X" + idNr;
                return id;
            }
        }
    }
}
