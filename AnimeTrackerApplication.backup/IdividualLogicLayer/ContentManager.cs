﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public class ContentManager
    {
        List<Content> contentApplication = new List<Content>();

        public ContentManager()
        {

        }

        public List<Content> ContentApplication { get { return contentApplication; } }

        public void AddContentToList(Content content)
        {
            contentApplication.Add(content);
        }

        public void SetAnimeId(Anime anime)
        {
            int idNr;
            while (true)
            {
                idNr = GiveRandomId();
                string id = "A" + idNr;
                if (!contentApplication.Select(x => x.Id).Contains(id))
                {
                    anime.Id = id;
                    break;
                }    
            }
        }

        private int GiveRandomId()
        {
            Random r = new Random();
            int rNum = r.Next(1, 999999);
            return rNum;
        }
    }
}
