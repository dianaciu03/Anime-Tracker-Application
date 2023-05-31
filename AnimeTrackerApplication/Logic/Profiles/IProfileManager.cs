using Logic.Enums;

namespace Logic.Profiles
{
    public interface IProfileManager
    {
        void AddPreferedGenres(Profile profile);
        void DeleteContentFromList(Profile profile);
        Profile GetProfileById(int id);
    }
}