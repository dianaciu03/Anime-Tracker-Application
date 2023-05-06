using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Users;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : BaseDAL, IUserRepository
    {
        public List<User> GetAllUsers()
        {
            List<User> listUsers = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM [User]";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            //user factory?
                            switch (role)
                            {
                                case "Admin":
                                    User admin = new Admin(userId, name, email, hashedPassword, joinDate, salt);
                                    listUsers.Add(admin);
                                    break;

                                case "Maintainer":
                                    User maintainer = new Maintainer(userId, name, email, hashedPassword, joinDate, salt);
                                    listUsers.Add(maintainer);
                                    break;

                                case "RegisteredWebUser":
                                    User webUser = new RegisteredWebUser(userId, name, email, hashedPassword, joinDate, salt);
                                    listUsers.Add(webUser);
                                    break;
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the users!");
            }
            return listUsers;
        }

        public List<RegisteredWebUser> GetAllWebUsers()
        {
            List<RegisteredWebUser> listUsers = new List<RegisteredWebUser>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM [User] WHERE Role = 'RegisteredWebUser'";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            User webUser = new RegisteredWebUser(userId, name, email, hashedPassword, joinDate, salt);
                            listUsers.Add((RegisteredWebUser)webUser);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the users!");
            }
            return listUsers;
        }

        public User? GetUserByEmail(string email)
        {
            User user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM [User] WHERE Email=@Email";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            switch (role)
                            {
                                case "Admin":
                                    user = new Admin(userId, name, email, hashedPassword, joinDate, salt);
                                    break;

                                case "Maintainer":
                                    user = new Maintainer(userId, name, email, hashedPassword, joinDate, salt);
                                    break;
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the user!");
            }
            return user;
        }

        public RegisteredWebUser? GetWebUserByEmail(string email)
        {
            RegisteredWebUser user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM [User] INNER JOIN Profile ON [User].UserId = Profile.UserId WHERE Email=@Email";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));
                            string username = reader.GetString(reader.GetOrdinal("Username"));
                            user = new RegisteredWebUser(userId, name, email, hashedPassword, joinDate, salt);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the user!");
            }
            return user;
        }

        public User? GetUserById(int id)
        {
            User user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM [User] WHERE UserId=@UserId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@UserId", id);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string? username = reader.IsDBNull(reader.GetOrdinal("Username")) ? null : reader.GetString(reader.GetOrdinal("Username"));
                            string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            switch (role)
                            {
                                case "Admin":
                                    user = new Admin(id, name, email, hashedPassword, joinDate, salt);
                                    break;

                                case "Maintainer":
                                    user = new Maintainer(id, name, email, hashedPassword, joinDate, salt);
                                    break;

                                case "RegisteredWebUser":
                                    user = new RegisteredWebUser(id, name, email, hashedPassword, joinDate, salt);
                                    break;
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the user!");
            }
            return user;
        }

        public RegisteredWebUser? GetWebUserById(int id)
        {
            RegisteredWebUser user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT [User].*, Username FROM [User] INNER JOIN Profile ON [User].UserId = Profile.UserId WHERE [User].UserId=@UserId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@UserId", id);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));
                            string username = reader.GetString(reader.GetOrdinal("Username"));
                            user = new RegisteredWebUser(id, name, email, hashedPassword, joinDate, salt);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the user!");
            }
            return user;
        }

        public Profile GetProfileByWebUserId(int id)
        {
            Profile profile = null;
            int oldProfileId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Profile INNER JOIN CustomList 
                                     ON Profile.ProfileId = CustomList.ProfileId 
                                     WHERE UserId=@UserId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@UserId", id);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int newProfileId = reader.GetInt32(reader.GetOrdinal("ProfileId"));
                            if (newProfileId != oldProfileId)
                            {
                                oldProfileId = newProfileId;
                                string username = reader.GetString(reader.GetOrdinal("Username"));
                                profile = new Profile(oldProfileId, username);
                            }
                            else
                            {
                                int listId = reader.GetInt32(3);
                                string name = reader.GetString(4);
                                string contentType = reader.GetString(6);
                                CustomList customList = new CustomList(listId, name, contentType);
                                profile.AddCustomList(customList);
                                int nrContent = -1;

                                switch(contentType)
                                {
                                    case "Anime":
                                        string queryAnime = @$"SELECT COUNT(*) FROM CustomList INNER JOIN List_Anime 
                                                               ON CustomList.ListId = List_Anime.ListId WHERE ListId = {listId}";
                                        using (SqlCommand commandList = new SqlCommand(queryAnime, conn))
                                        {
                                            nrContent = (int)commandList.ExecuteScalar();
                                        }
                                        if (nrContent > 0)
                                        {
                                            AnimeRepository ar = new AnimeRepository();
                                            string getAnime = @$"SELECT * FROM List_Anime WHERE ListId = {listId}";
                                            using (SqlCommand commandAnime = new SqlCommand(getAnime, conn))
                                            {
                                                SqlDataReader readerAnime = commandAnime.ExecuteReader();
                                                while (readerAnime.Read())
                                                {
                                                    int animeId = readerAnime.GetInt32(1);
                                                    Anime anime = ar.GetAnimeById(animeId);
                                                    customList.AddContent(anime);
                                                }
                                            }
                                        }
                                        break;

                                    case "Manga":
                                        string queryManga = @$"SELECT COUNT(*) FROM CustomList INNER JOIN List_Manga 
                                                               ON CustomList.ListId = List_Manga.ListId WHERE ListId = {listId}";
                                        using (SqlCommand commandList = new SqlCommand(queryManga, conn))
                                        {
                                            nrContent = (int)commandList.ExecuteScalar();
                                        }
                                        if (nrContent > 0)
                                        {
                                            MangaRepository mr = new MangaRepository();
                                            string getManga = @$"SELECT * FROM List_Manga WHERE ListId = {listId}";
                                            using (SqlCommand commandManga = new SqlCommand(getManga, conn))
                                            {
                                                SqlDataReader readerManga = commandManga.ExecuteReader();
                                                while (readerManga.Read())
                                                {
                                                    int mangaId = readerManga.GetInt32(1);
                                                    Manga manga = mr.GetMangaById(mangaId);
                                                    customList.AddContent(manga);
                                                }
                                            }
                                        }
                                        break;

                                    case "Character":
                                        string queryCharacter = @$"SELECT COUNT(*) FROM CustomList INNER JOIN List_Character 
                                                               ON CustomList.ListId = List_Character.ListId WHERE ListId = {listId}";
                                        using (SqlCommand commandList = new SqlCommand(queryCharacter, conn))
                                        {
                                            nrContent = (int)commandList.ExecuteScalar();
                                        }
                                        if (nrContent > 0)
                                        {
                                            CharacterRepository cr = new CharacterRepository();
                                            string getCharacters = @$"SELECT * FROM List_Character WHERE ListId = {listId}";
                                            using (SqlCommand commandCharacters = new SqlCommand(getCharacters, conn))
                                            {
                                                SqlDataReader readerCharacters = commandCharacters.ExecuteReader();
                                                while (readerCharacters.Read())
                                                {
                                                    int characterId = readerCharacters.GetInt32(1);
                                                    Character character = cr.GetCharacterById(characterId);
                                                    customList.AddContent(character);
                                                }
                                            }
                                        }
                                        break;
                                }

                            }

                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the user!");
            }
            return profile;
        }

        public void AddUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"INSERT INTO [User] (Name, Email, JoinDate, Salt, Password, Role) 
                                         VALUES (@Name, @Email, @JoinDate, @Salt, @Password, @Role); 
                                         SELECT SCOPE_IDENTITY();";
                        int userId = 0;
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@Name", user.Name);
                            command.Parameters.AddWithValue("@Email", user.Email);
                            command.Parameters.AddWithValue("@JoinDate", user.JoinDate);
                            command.Parameters.AddWithValue("@Password", user.HashedPassword);
                            command.Parameters.AddWithValue("@Salt", user.Salt);
                            command.Parameters.AddWithValue("@Role", user.GetType().Name);
                            userId = Convert.ToInt32(command.ExecuteScalar());

                            if (user is RegisteredWebUser)
                            {
                                RegisteredWebUser webUser = (RegisteredWebUser)user;
                                string query2 = @"INSERT INTO Profile (UserId, Username) 
                                         VALUES (@UserId, @Username); 
                                         SELECT SCOPE_IDENTITY();";
                                int profileId = 0;
                                using(SqlCommand profileCommand = new SqlCommand(query2, conn, transaction))
                                {
                                    profileCommand.Parameters.AddWithValue("@UserId", userId);
                                    profileCommand.Parameters.AddWithValue("@Username", webUser.Profile.Username);
                                    profileId = Convert.ToInt32(profileCommand.ExecuteScalar());
                                } 
                                foreach(CustomList custom in webUser.Profile.GetAllCustomLists())
                                {
                                    string query3 = @"INSERT INTO CustomList (Name, ProfileId) 
                                         VALUES (@Name, @ProfileId);";
                                    using (SqlCommand listCommand = new SqlCommand(query3, conn, transaction))
                                    {
                                        listCommand.Parameters.AddWithValue("@Name", custom.Name);
                                        listCommand.Parameters.AddWithValue("@ProfileId", profileId);
                                        listCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            //command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"User couldn't be added: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }

        //update

        //delete

    }
}
