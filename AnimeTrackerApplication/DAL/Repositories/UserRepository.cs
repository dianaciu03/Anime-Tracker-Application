using Logic.Animes;
using Logic.Characters;
using Logic.Contents;
using Logic.Enums;
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

                                case "RegisteredWebUser":
                                    user = new RegisteredWebUser(userId, name, email, hashedPassword, joinDate, salt);
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

        public List<User> GetSearchedUsers(string nameU, string usernameU, string roleU, int yearsU)
        {
            List<User> users = new List<User>();
            User user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM [User]
                                       WHERE Name LIKE '%' + @Name + '%' 
                                       AND Role LIKE '%' + @Role + '%' 
                                       AND DATEDIFF(year, Joindate, GETDATE()) >= @Years;";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", nameU);
                        command.Parameters.AddWithValue("@Role", roleU);
                        command.Parameters.AddWithValue("@Years", yearsU);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("UserId"));
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            switch (role)
                            {
                                case "Admin":
                                    user = new Admin(id, name, email, hashedPassword, joinDate, salt);
                                    users.Add(user);
                                    break;

                                case "Maintainer":
                                    user = new Maintainer(id, name, email, hashedPassword, joinDate, salt);
                                    users.Add(user);
                                    break;

                                case "RegisteredWebUser":
                                    user = new RegisteredWebUser(id, name, email, hashedPassword, joinDate, salt);
                                    Profile profile = GetProfileByWebUserId(user.Id);
                                    RegisteredWebUser webUser = (RegisteredWebUser)user;
                                    webUser.Profile = profile;
                                    users.Add(user);
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
                throw new Exception("There were issues while trying to retrieve the users!");
            }
            return users;
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
                                int listId = reader.GetInt32(3);
                                string name = reader.GetString(4);
                                string contentType = reader.GetString(6);
                                CustomList customList = new CustomList(listId, name, contentType);
                                profile.AddCustomList(customList);
                            }
                            else
                            {
                                int listId = reader.GetInt32(3);
                                string name = reader.GetString(4);
                                string contentType = reader.GetString(6);
                                CustomList customList = new CustomList(listId, name, contentType);
                                profile.AddCustomList(customList);
                            }
                        }
                        reader.Close();

                        foreach (CustomList custom in profile.GetAllCustomLists())
                        {
                            int nrContent = -1;
                            switch (custom.ContentType)
                            {
                                case "Anime":
                                    string queryAnime = @$"SELECT COUNT(*) FROM CustomList INNER JOIN List_Anime 
                                                               ON CustomList.ListId = List_Anime.ListId WHERE CustomList.ListId = {custom.Id}";
                                    using (SqlCommand commandList = new SqlCommand(queryAnime, conn))
                                    {
                                        nrContent = (int)commandList.ExecuteScalar();
                                    }
                                    if (nrContent > 0)
                                    {
                                        AnimeRepository ar = new AnimeRepository();
                                        string getAnime = @$"SELECT * FROM List_Anime WHERE ListId = {custom.Id}";
                                        using (SqlCommand commandAnime = new SqlCommand(getAnime, conn))
                                        {
                                            SqlDataReader readerAnime = commandAnime.ExecuteReader();
                                            while (readerAnime.Read())
                                            {
                                                int animeId = readerAnime.GetInt32(1);
                                                Anime anime = ar.GetAnimeById(animeId);
                                                custom.AddContent(anime);
                                            }
                                            readerAnime.Close();
                                        }
                                    }
                                    break;

                                case "Manga":
                                    string queryManga = @$"SELECT COUNT(*) FROM CustomList INNER JOIN List_Manga 
                                                               ON CustomList.ListId = List_Manga.ListId WHERE CustomList.ListId = {custom.Id}";
                                    using (SqlCommand commandList = new SqlCommand(queryManga, conn))
                                    {
                                        nrContent = (int)commandList.ExecuteScalar();
                                    }
                                    if (nrContent > 0)
                                    {
                                        MangaRepository mr = new MangaRepository();
                                        string getManga = @$"SELECT * FROM List_Manga WHERE ListId = {custom.Id}";
                                        using (SqlCommand commandManga = new SqlCommand(getManga, conn))
                                        {
                                            SqlDataReader readerManga = commandManga.ExecuteReader();
                                            while (readerManga.Read())
                                            {
                                                int mangaId = readerManga.GetInt32(1);
                                                Manga manga = mr.GetMangaById(mangaId);
                                                custom.AddContent(manga);
                                            }
                                            readerManga.Close();
                                        }
                                    }
                                    break;

                                case "Character":
                                    string queryCharacter = @$"SELECT COUNT(*) FROM CustomList INNER JOIN List_Character 
                                                               ON CustomList.ListId = List_Character.ListId WHERE CustomList.ListId = {custom.Id}";
                                    using (SqlCommand commandList = new SqlCommand(queryCharacter, conn))
                                    {
                                        nrContent = (int)commandList.ExecuteScalar();
                                    }
                                    if (nrContent > 0)
                                    {
                                        CharacterRepository cr = new CharacterRepository();
                                        string getCharacters = @$"SELECT * FROM List_Character WHERE ListId = {custom.Id}";
                                        using (SqlCommand commandCharacters = new SqlCommand(getCharacters, conn))
                                        {
                                            SqlDataReader readerCharacters = commandCharacters.ExecuteReader();
                                            while (readerCharacters.Read())
                                            {
                                                int characterId = readerCharacters.GetInt32(1);
                                                Character character = cr.GetCharacterById(characterId);
                                                custom.AddContent(character);
                                            }
                                            readerCharacters.Close();
                                        }
                                    }
                                    break;
                            }
                        }

                        int nrGenre = 0;
                        string queryGenre = @$"SELECT COUNT(*) FROM Profile_Genre INNER JOIN Profile 
                                                               ON Profile_Genre.ProfileId = Profile.ProfileId WHERE Profile.ProfileId = {oldProfileId}";
                        using (SqlCommand commandList = new SqlCommand(queryGenre, conn))
                        {
                            nrGenre = (int)commandList.ExecuteScalar();
                        }

                        if (nrGenre > 0)
                        {
                            string getGenre = @$"SELECT * FROM Profile_Genre INNER JOIN ContentGenre 
                                                 ON Profile_Genre.GenreId = ContentGenre.GenreId WHERE ProfileId = {oldProfileId}";
                            using (SqlCommand commandGenre = new SqlCommand(getGenre, conn))
                            {
                                SqlDataReader readerGenre = commandGenre.ExecuteReader();
                                while (readerGenre.Read())
                                {
                                    string genreString = readerGenre.GetString(readerGenre.GetOrdinal("Genre"));
                                    Genre genre = (Genre)Enum.Parse(typeof(Genre), genreString);
                                    profile.AddGenre(genre);
                                }
                                readerGenre.Close();
                            }
                        }
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
                                using (SqlCommand profileCommand = new SqlCommand(query2, conn, transaction))
                                {
                                    profileCommand.Parameters.AddWithValue("@UserId", userId);
                                    profileCommand.Parameters.AddWithValue("@Username", webUser.Profile.Username);
                                    profileId = Convert.ToInt32(profileCommand.ExecuteScalar());
                                }
                                List<CustomList> customLists = webUser.Profile.GetAllCustomLists();
                                foreach (CustomList custom in customLists)
                                {
                                    string query3 = @"INSERT INTO CustomList (Name, ProfileId, ContentType) 
                                         VALUES (@Name, @ProfileId, @ContentType);";
                                    using (SqlCommand listCommand = new SqlCommand(query3, conn, transaction))
                                    {
                                        listCommand.Parameters.AddWithValue("@Name", custom.Name);
                                        listCommand.Parameters.AddWithValue("@ProfileId", profileId);
                                        listCommand.Parameters.AddWithValue("@ContentType", custom.ContentType);
                                        listCommand.ExecuteNonQuery();
                                    }
                                }
                            }
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

        public void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"UPDATE [User] SET Salt=@Salt, Password=@Password WHERE UserId=@UserId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@UserId", user.Id);
                            command.Parameters.AddWithValue("@Salt", user.Salt);
                            command.Parameters.AddWithValue("@Password", user.HashedPassword);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception($"User couldn't be updated!");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception($"An error occurred!");
            }
        }

        public void DeleteAccount(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query2 = @"DELETE FROM [User] WHERE UserId=@UserId";
                        using (SqlCommand command = new SqlCommand(query2, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception($"Account couldn't be deleted!");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception($"An error occurred!");
            }
        }
    }
}
