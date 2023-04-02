using Logic.Animes;
using Logic.Contents;
using Logic.Enums;
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
    public class UserRepository : BaseDAL, IUser
    {
        public List<User> GetAllUsers()
        {
            List<User> listUsers = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM User";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            string userId = reader.GetString(reader.GetOrdinal("UserId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string username = reader.GetString(reader.GetOrdinal("UserName"));
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string password = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            switch (role)
                            {
                                case "Admin":
                                    User admin = new Admin(name, email, password, joinDate);
                                    listUsers.Add(admin);
                                    break;

                                case "Maintainer":
                                    User maintainer = new Maintainer(name, email, password, joinDate);
                                    listUsers.Add(maintainer);
                                    break;

                                case "RegisteredWebUser":
                                    User webUser = new RegisteredWebUser(name, email, password, joinDate, username);
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
                    string query1 = @$"SELECT * FROM User WHERE Role = 'RegisteredWebUser'";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            string userId = reader.GetString(reader.GetOrdinal("UserId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string username = reader.GetString(reader.GetOrdinal("UserName"));
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string password = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            User webUser = new RegisteredWebUser(name, email, password, joinDate, username);
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

        public RegisteredWebUser? GetWebUserByEmail(string email)
        {
            RegisteredWebUser webUser = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @$"SELECT * FROM User WHERE Role = 'RegisteredWebUser' AND Email = '{email}'";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string userId = reader.GetString(reader.GetOrdinal("UserId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string username = reader.GetString(reader.GetOrdinal("UserName"));
                            string password = reader.GetString(reader.GetOrdinal("Password"));
                            string salt = reader.GetString(reader.GetOrdinal("Salt"));
                            DateTime joinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));

                            webUser = new RegisteredWebUser(name, email, password, joinDate, username);
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
            return webUser;
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
                        string query = @"INSERT INTO [User] (Name, UserName, Email, JoinDate, Salt, Password, Role) VALUES (@Name, @UserName, @Email, @JoinDate, @Salt, @Password, @Role)";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@Name", user.Name);
                            if (user is RegisteredWebUser)
                            {
                                RegisteredWebUser webUser = (RegisteredWebUser)user;
                                command.Parameters.AddWithValue("@UserName", webUser.Username);
                            }
                            else
                                command.Parameters.AddWithValue("@UserName", DBNull.Value);
                            command.Parameters.AddWithValue("@Email", user.Email);
                            command.Parameters.AddWithValue("@JoinDate", user.JoinDate);
                            command.Parameters.AddWithValue("@Password", user.Password);
                            command.Parameters.AddWithValue("@Salt", DBNull.Value);
                            command.Parameters.AddWithValue("@Role", user.GetType().Name);

                            command.ExecuteNonQuery();
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
