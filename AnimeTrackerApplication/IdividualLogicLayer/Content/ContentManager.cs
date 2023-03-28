using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IdividualLogicLayer
{
    public abstract class ContentManager
    {
        List<Content> contentApplication;

        public ContentManager()
        {
            contentApplication = new List<Content>();
        }

        public List<Content> ContentApplication { get { return contentApplication; } }


        public virtual string GiveId()
        {
            while (true)
            {
                Random r = new Random();
                int idNr = r.Next(1, 9999);
                string id = "X" + idNr;
                if (!contentApplication.Select(x => x.Id).Contains(id))
                {
                    return id;
                }
            }
        }
    }
}
