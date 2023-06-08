using Logic.Enums;
using Logic.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace DAL.Repositories
{
    public interface IProfileRepository
    {
        void AddPreferredGenres(Genre[] genres, int profileId);
        void DeleteContentFromList(int profileId);
        Profile GetProfileById(int id);
        void AddProfilePicture(int profileId, string name, MemoryStream ms, string contentType);
        FileContentResult GetProfilePicture(int profileId);
        bool HasProfilePicture(int profileId);
        void UpdateProfilePicture(int profileId, string name, MemoryStream ms, string contentType);
    }
}