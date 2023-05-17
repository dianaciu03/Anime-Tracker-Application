namespace Logic.Profiles
{
    public interface ICustomListRepository
    {
        void AddContentToList(object content, int listId, string contentType);
    }
}