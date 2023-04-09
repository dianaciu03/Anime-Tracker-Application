using Logic.Animes;
using Logic.Contents;
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
    public class MangaRepository : BaseDAL
    {
        public List<Manga> GetAllManga()
        {
            List<Manga> listManga = new List<Manga>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Manga";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            int mangaId = reader.GetInt32(reader.GetOrdinal("MangaId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string creator = reader.GetString(reader.GetOrdinal("Creator"));
                            int nrChapters = reader.GetInt32(reader.GetOrdinal("NrChapters"));
                            int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                            string status = reader.GetString(reader.GetOrdinal("Status"));
                            decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));
                            string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                            MangaStatus statusManga = (MangaStatus)Enum.Parse(typeof(MangaStatus), status);

                            Content manga = new Manga(mangaId, name, description, rating, releaseYear, imageURL, statusManga, nrChapters, creator, new List<Genre>());
                            listManga.Add((Manga)manga);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the manga!");
            }
            return listManga;
        }

        public int GetNrManga()
        {
            int nrManga = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT COUNT(*) FROM Manga";
                    using (SqlCommand command = new SqlCommand(query1, conn))
                    {
                        nrManga = (int)command.ExecuteScalar();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("Couldn't provide the numbers of manga at the moment!");
            }
            return nrManga;
        }

        public void AddManga(Manga manga)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"INSERT INTO Manga (Name, Creator, NrChapters, ReleaseYear, Status, Rating, Description, Image) VALUES (@Name, @Creator, @NrChapters, @ReleaseYear, @Status, @Rating, @Description, @Image)";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@Name", manga.Name);
                            command.Parameters.AddWithValue("@Studio", manga.Creator);
                            command.Parameters.AddWithValue("@NrEpisodes", manga.NrChapters);
                            command.Parameters.AddWithValue("@ReleaseYear", manga.ReleaseYear);
                            command.Parameters.AddWithValue("@ReleaseSeason", manga.Status.ToString());
                            command.Parameters.AddWithValue("@Rating", manga.Rating);
                            command.Parameters.AddWithValue("@Description", manga.Description);
                            command.Parameters.AddWithValue("@Image", manga.ImageURL);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Manga couldn't be added: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }

        public void UpdateManga(int id, string name, string creator, int nrChapters, int releaseYear, MangaStatus status, decimal rating, string description, string imageURL)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"UPDATE Manga SET Name=@Name, Creator=@Creator, NrChapters=@NrChapters, ReleaseYear=@ReleaseYear, Status=@Status, Rating=@Rating, Description=@Description, Image=@Image WHERE MangaId=@MangaId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@MangaId", id);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Creator", creator);
                            command.Parameters.AddWithValue("@NrChapters", nrChapters);
                            command.Parameters.AddWithValue("@ReleaseYear", releaseYear);
                            command.Parameters.AddWithValue("@Status", status.ToString());
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
                        throw new Exception($"Manga couldn't be updated: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }


        public void DeleteManga(int mangaId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"DELETE FROM Manga WHERE MangaId=@MangaId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@MangaId", mangaId);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Manga couldn't be deleted: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }

        public Manga? GetMangaById(int mangaId)
        {
            Content manga = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Manga WHERE MangaId=@MangaId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@MangaId", mangaId);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int mangaid = reader.GetInt32(reader.GetOrdinal("MangaId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string creator = reader.GetString(reader.GetOrdinal("Creator"));
                            int nrChapters = reader.GetInt32(reader.GetOrdinal("NrChapters"));
                            int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                            string status = reader.GetString(reader.GetOrdinal("Status"));
                            decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));
                            string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                            MangaStatus mangaStatus = (MangaStatus)Enum.Parse(typeof(MangaStatus), status);

                            manga = new Manga(mangaid, name, description, rating, releaseYear, imageURL, mangaStatus, nrChapters, creator, new List<Genre>());
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the manga!");
            }
            return (Manga)manga;
        }
    }
}
