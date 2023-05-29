﻿using Logic.Profiles;

namespace Logic.Users
{
    public interface IUserManager
    {
        void AddUser(User user);
        List<User> GetAllUsers();
        List<RegisteredWebUser> GetAllWebUsers();
        User? GetUserByEmail(string email);
        RegisteredWebUser? GetWebUserByEmail(string email);
        User? GetUserById(int id);
        RegisteredWebUser? GetWebUserById(int id);
        Profile GetProfileByWebUserId(int id);
        bool LoginUser(string password, string email);
    }
}