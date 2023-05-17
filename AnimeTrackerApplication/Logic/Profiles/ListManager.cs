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
        private readonly ICustomListRepository _mangaDataHandler;

        public ListManager(ICustomListRepository mangaDataHandler)
        {
            _mangaDataHandler = mangaDataHandler;
        }

        public void AddContentToCustomList(object content, CustomList customList)
        {
            _mangaDataHandler.AddContentToList(content, customList.Id, customList.ContentType);
        }
    }
}
