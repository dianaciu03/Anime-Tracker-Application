using Logic.Users;

namespace Logic.Users
{
    public interface IUser
    {
        void AddUser(User user);
        List<User> GetAllUsers();
        List<RegisteredWebUser> GetAllWebUsers();
        User? GetUserByEmail(string email);
    }
}