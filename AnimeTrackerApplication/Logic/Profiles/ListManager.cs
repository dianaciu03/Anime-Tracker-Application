using Logic.Mangas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class ListManager : IListManager
    {
        private readonly ICustomListRepository _listDataHandler;

        public ListManager(ICustomListRepository listDataHandler)
        {
            _listDataHandler = listDataHandler;
        }

        public void AddContentToCustomList(object content, CustomList customList)
        {
            try
            {
                _listDataHandler.AddContentToList(content, customList.Id, customList.ContentType);
            }
            catch(Exception)
            {
                return;
            }
        }

        public void DeleteContentFromList(object content, List<CustomList> customLists)
        {
            foreach (CustomList l in customLists)
            {
                _listDataHandler.DeleteContentFromList(content, l.Id, l.ContentType);
            }
        }

        public List<CustomList> GetAnimeListByProfileId(int id)
        {
            return _listDataHandler.GetAnimeListByProfileId(id);
        }

        public List<CustomList> GetMangaListByProfileId(int id)
        {
            return _listDataHandler.GetMangaListByProfileId(id);
        }
    }
}
