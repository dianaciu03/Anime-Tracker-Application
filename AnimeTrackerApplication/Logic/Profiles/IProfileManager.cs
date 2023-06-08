using Logic.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Logic.Profiles
{
    public interface IProfileManager
    {
        void AddPreferedGenres(Profile profile);
        void DeleteContentFromList(Profile profile);
        Profile GetProfileById(int id);

        void AddProfilePicture(int profileId, string name, MemoryStream ms, string contentType);
        void UpdateProfilePicture(int profileId, string name, MemoryStream ms, string contentType);
        FileContentResult GetProfilePicture(int profileId);
        bool HasProfilePicture(int profileId);
    }
}