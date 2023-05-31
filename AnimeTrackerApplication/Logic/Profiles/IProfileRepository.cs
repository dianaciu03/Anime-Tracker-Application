using Logic.Enums;
using Logic.Profiles;

namespace DAL.Repositories
{
    public interface IProfileRepository
    {
        void AddPreferredGenres(Genre[] genres, int profileId);
        void DeleteContentFromList(int profileId);
        Profile GetProfileById(int id);
    }
}