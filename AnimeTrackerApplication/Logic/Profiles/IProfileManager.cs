using Logic.Enums;

namespace Logic.Profiles
{
    public interface IProfileManager
    {
        void AddPreferedGenres(Profile profile);
        void DeleteContentFromList(Profile profile);
        Profile GetProfileById(int id);

        void AddProfilePicture(int profileId, string name, MemoryStream ms, string contentType);
    }
}