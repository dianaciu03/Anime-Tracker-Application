namespace Logic.Profiles
{
    public interface ICustomListRepository
    {
        void AddContentToList(object content, int listId, string contentType);
        void DeleteContentFromList(object content, int listId, string contentType);
        List<CustomList> GetAnimeListByProfileId(int id);
    }
}