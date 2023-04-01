using Logic.Animes;
using Logic.Contents;
using Logic.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Repositories
{
    public class AnimeRepository : BaseDAL, IAnime
    {
        public List<Anime> GetAllAnime()
        {
            List<Anime> listAnime = new List<Anime>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Anime";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            string animeId = reader.GetString(reader.GetOrdinal("AnimeId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string studio = reader.GetString(reader.GetOrdinal("Studio"));
                            int nrEpisodes = reader.GetInt32(reader.GetOrdinal("NrEpisodes"));
                            int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                            string releaseSeason = reader.GetString(reader.GetOrdinal("ReleaseSeason"));
                            decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));
                            string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                            Season season = (Season)Enum.Parse(typeof(Season), releaseSeason);

                            Content anime = new Anime(animeId, name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, new List<Genre>());
                            listAnime.Add((Anime)anime);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the animes!");
            }
            return listAnime;
        }

        public int GetNrAnime()
        {
            int nrAnime = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT COUNT(*) FROM Anime";
                    using (SqlCommand command = new SqlCommand(query1, conn))
                    {
                        nrAnime = (int)command.ExecuteScalar();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("Couldn't provide the numbers of anime at the moment!");
            }
            return nrAnime;
        }

        public void AddAnime(Anime anime)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"INSERT INTO Anime (AnimeId, Name, Studio, NrEpisodes, ReleaseYear, ReleaseSeason, Rating, Description, Image) VALUES (@AnimeId,@Name,@Studio,@NrEpisodes,@ReleaseYear,@ReleaseSeason,@Rating,@Description,@Image)";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@AnimeId", anime.Id);
                            command.Parameters.AddWithValue("@Name", anime.Name);
                            command.Parameters.AddWithValue("@Studio", anime.Studio);
                            command.Parameters.AddWithValue("@NrEpisodes", anime.NrEpisodes);
                            command.Parameters.AddWithValue("@ReleaseYear", anime.ReleaseYear);
                            command.Parameters.AddWithValue("@ReleaseSeason", anime.SeasonAnime.ToString());
                            command.Parameters.AddWithValue("@Rating", anime.Rating);
                            command.Parameters.AddWithValue("@Description", anime.Description);
                            command.Parameters.AddWithValue("@Image", anime.ImageURL);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Anime couldn't be added: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }

        public void UpdateAnime(string id, string name, string studio, int nrEpisodes, int releaseYear, Season releaseSeason, decimal rating, string description, string imageURL)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"UPDATE Anime SET Name=@Name, Studio=@Studio, NrEpisodes=@NrEpisodes, ReleaseYear=@ReleaseYear, ReleaseSeason=@ReleaseSeason, Rating=@Rating, Description=@Description, Image=@Image WHERE AnimeId=@AnimeId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@AnimeId", id);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Studio", studio);
                            command.Parameters.AddWithValue("@NrEpisodes", nrEpisodes);
                            command.Parameters.AddWithValue("@ReleaseYear", releaseYear);
                            command.Parameters.AddWithValue("@ReleaseSeason", releaseSeason.ToString());
                            command.Parameters.AddWithValue("@Rating", rating);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Image", imageURL);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Anime couldn't be updated: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }


        public void DeleteAnime(string animeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"DELETE FROM Anime WHERE AnimeId=@AnimeId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@AnimeId", animeId);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"An error occurred: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }
    }
}
