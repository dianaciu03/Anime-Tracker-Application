using Logic.Animes;
using Logic.Characters;
using Logic.Enums;
using Logic.Mangas;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProfileRepository : BaseDAL, IProfileRepository
    {
        public void AddPreferredGenres(Genre[] genres, int profileId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        foreach (Genre genre in genres)
                        {
                            string query = @"INSERT INTO Profile_Genre (ProfileId, GenreId)
                                        VALUES (@ProfileId, (SELECT GenreId FROM ContentGenre WHERE Genre = @Genre))";
                            using (SqlCommand profileCommand = new SqlCommand(query, conn, transaction))
                            {
                                profileCommand.Parameters.Clear();
                                profileCommand.Parameters.AddWithValue("@ProfileId", profileId);
                                profileCommand.Parameters.AddWithValue("@Genre", genre.ToString());
                                profileCommand.ExecuteNonQuery();

                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception($"Content couldn't be added");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception($"An error occurred");
            }
        }

        public void DeleteContentFromList(int profileId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        string query1 = @"DELETE FROM Profile_Genre WHERE ProfileId = @ProfileId"; 
                        using (SqlCommand animeCommand = new SqlCommand(query1, conn, transaction))
                        {
                            animeCommand.Parameters.Clear();
                            animeCommand.Parameters.AddWithValue("@ProfileId", profileId);
                            animeCommand.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception($"An error occurred");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception($"An error occurred");
            }
        }
    }
}
