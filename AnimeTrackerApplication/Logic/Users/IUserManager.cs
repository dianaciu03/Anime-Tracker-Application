using Logic.Profiles;

namespace Logic.Users
{
    public interface IUserManager
    {
        List<User> GetAllUsers();
        List<RegisteredWebUser> GetAllWebUsers();
        User? GetUserByEmail(string email);
        RegisteredWebUser? GetWebUserByEmail(string email);
        User? GetUserById(int id);
        RegisteredWebUser? GetWebUserById(int id);
        Profile GetProfileByWebUserId(int id);
        bool LoginUser(string password, string email);
        bool UserExists(string email);
        void AddWebUser(string name, string email, string password, string username);
        void AddUser(string name, string email, string password, string role);
        void UpdateUser(User user, string password);
        List<User> GetSearchedUsers(string nameU, string usernameU, string roleU, int yearsU);
    }
}