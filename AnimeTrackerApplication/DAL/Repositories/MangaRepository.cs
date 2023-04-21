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
using System.Xml.Linq;

namespace DAL.Repositories
{
    public class MangaRepository : BaseDAL, IMangaRepository
    {
        public List<Manga> GetAllManga(string sortBy, bool ascending)
        {
            List<Manga> listManga = new List<Manga>();
            int oldMangaId = 0;
            Content manga = new Manga();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string sortDirection = ascending ? "ASC" : "DESC";
                    string query1 = @$"SELECT Manga.*, ContentGenre.Genre FROM Manga INNER JOIN Manga_Genre 
                                       ON Manga.MangaId = Manga_Genre.MangaId INNER JOIN ContentGenre 
                                       ON Manga_Genre.GenreId = ContentGenre.GenreId
                                       ORDER BY {sortBy} {sortDirection}";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            int newMangaId = reader.GetInt32(reader.GetOrdinal("MangaId"));
                            if (newMangaId != oldMangaId)
                            {
                                oldMangaId = newMangaId;

                                string name = reader.GetString(reader.GetOrdinal("Name"));
                                string creator = reader.GetString(reader.GetOrdinal("Creator"));
                                int nrChapters = reader.GetInt32(reader.GetOrdinal("NrChapters"));
                                int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string status = reader.GetString(reader.GetOrdinal("Status"));
                                decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                                MangaStatus statusManga = (MangaStatus)Enum.Parse(typeof(MangaStatus), status);

                                List<Genre> genres = new List<Genre>();
                                string genreManga = reader.GetString(reader.GetOrdinal("Genre"));
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreManga);
                                genres.Add(genre);
                                manga = new Manga(oldMangaId, name, description, rating, releaseYear, imageURL, statusManga, nrChapters, creator, genres);
                                listManga.Add((Manga)manga);
                            }
                            else if (newMangaId == oldMangaId)
                            {
                                string genreManga = reader.GetString(9);
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreManga);
                                manga.AddGenre(genre);
                            }
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
                        string query = @"INSERT INTO Manga (Name, Creator, NrChapters, ReleaseYear, Status, Rating, Description, Image) 
                                         VALUES (@Name, @Creator, @NrChapters, @ReleaseYear, @Status, @Rating, @Description, @Image);
                                         SELECT SCOPE_IDENTITY();";
                        int mangaId = 0;
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@Name", manga.Name);
                            command.Parameters.AddWithValue("@Creator", manga.Creator);
                            command.Parameters.AddWithValue("@NrChapters", manga.NrChapters);
                            command.Parameters.AddWithValue("@ReleaseYear", manga.ReleaseYear);
                            command.Parameters.AddWithValue("@Status", manga.Status.ToString());
                            command.Parameters.AddWithValue("@Rating", manga.Rating);
                            command.Parameters.AddWithValue("@Description", manga.Description);
                            command.Parameters.AddWithValue("@Image", manga.ImageURL);
                            mangaId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        foreach (Genre genre in manga.GetGenres())
                        {
                            string query2 = @"INSERT INTO Manga_Genre (MangaId, GenreId)
                                        VALUES (@MangaId, (SELECT GenreId FROM ContentGenre WHERE Genre = @Genre))";
                            using (SqlCommand genreCommand = new SqlCommand(query2, conn, transaction))
                            {
                                genreCommand.Parameters.Clear();
                                genreCommand.Parameters.AddWithValue("@MangaId", mangaId);
                                genreCommand.Parameters.AddWithValue("@Genre", genre.ToString());
                                genreCommand.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
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

        public void UpdateManga(Manga manga)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query1 = @"DELETE FROM Manga_Genre WHERE MangaId=@MangaId";
                        using (SqlCommand command = new SqlCommand(query1, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@MangaId", manga.Id);
                            command.ExecuteNonQuery();
                        }

                        string query2 = @"UPDATE Manga SET Name=@Name, Creator=@Creator, NrChapters=@NrChapters, ReleaseYear=@ReleaseYear, Status=@Status, Rating=@Rating, Description=@Description, Image=@Image WHERE MangaId=@MangaId";
                        using (SqlCommand command = new SqlCommand(query2, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@MangaId", manga.Id);
                            command.Parameters.AddWithValue("@Name", manga.Name);
                            command.Parameters.AddWithValue("@Creator", manga.Creator);
                            command.Parameters.AddWithValue("@NrChapters", manga.NrChapters);
                            command.Parameters.AddWithValue("@ReleaseYear", manga.ReleaseYear);
                            command.Parameters.AddWithValue("@Status", manga.Status.ToString());
                            command.Parameters.AddWithValue("@Rating", manga.Rating);
                            command.Parameters.AddWithValue("@Description", manga.Description);
                            command.Parameters.AddWithValue("@Image", manga.ImageURL);
                            command.ExecuteNonQuery();
                        }

                        foreach (Genre genre in manga.GetGenres())
                        {
                            string query3 = @"INSERT INTO Manga_Genre (MangaId, GenreId)
                                        VALUES (@MangaId, (SELECT GenreId FROM ContentGenre WHERE Genre = @Genre))";
                            using (SqlCommand genreCommand = new SqlCommand(query3, conn, transaction))
                            {
                                genreCommand.Parameters.Clear();
                                genreCommand.Parameters.AddWithValue("@MangaId", manga.Id);
                                genreCommand.Parameters.AddWithValue("@Genre", genre.ToString());
                                genreCommand.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
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
                        string query1 = @"DELETE FROM Manga_Genre WHERE MangaId=@MangaId";
                        using (SqlCommand command = new SqlCommand(query1, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@MangaId", mangaId);
                            command.ExecuteNonQuery();
                        }

                        string query = @"DELETE FROM Manga WHERE MangaId=@MangaId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@MangaId", mangaId);
                            command.ExecuteNonQuery();   
                        }
                        transaction.Commit();
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
            Manga manga = null;
            int oldMangaId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT Manga.*, ContentGenre.Genre FROM Manga INNER JOIN Manga_Genre 
                                     ON Manga.MangaId = Manga_Genre.MangaId INNER JOIN ContentGenre 
                                     ON Manga_Genre.GenreId = ContentGenre.GenreId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@MangaId", mangaId);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int newMangaId = reader.GetInt32(reader.GetOrdinal("MangaId"));
                            if (newMangaId != oldMangaId)
                            {
                                oldMangaId = newMangaId;

                                string name = reader.GetString(reader.GetOrdinal("Name"));
                                string creator = reader.GetString(reader.GetOrdinal("Creator"));
                                int nrChapters = reader.GetInt32(reader.GetOrdinal("NrChapters"));
                                int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string status = reader.GetString(reader.GetOrdinal("Status"));
                                decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                                MangaStatus statusManga = (MangaStatus)Enum.Parse(typeof(MangaStatus), status);

                                List<Genre> genres = new List<Genre>();
                                string genreManga = reader.GetString(reader.GetOrdinal("Genre"));
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreManga);
                                genres.Add(genre);
                                manga = new Manga(oldMangaId, name, description, rating, releaseYear, imageURL, statusManga, nrChapters, creator, genres);
                            }
                            else if (newMangaId == oldMangaId)
                            {
                                string genreManga = reader.GetString(9);
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreManga);
                                manga.AddGenre(genre);
                            }
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
            return manga;
        }

        public List<Manga> GetMangaByName(string name)
        {
            List<Manga> mangaList = new List<Manga>();
            Manga manga = null;
            int oldMangaId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT Manga.*, ContentGenre.Genre FROM Manga INNER JOIN Manga_Genre 
                                     ON Manga.MangaId = Manga_Genre.MangaId INNER JOIN ContentGenre 
                                     ON Manga_Genre.GenreId = ContentGenre.GenreId
                                     WHERE Name LIKE '%' + @Name + '%' ";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int newMangaId = reader.GetInt32(reader.GetOrdinal("MangaId"));
                            if (newMangaId != oldMangaId)
                            {
                                oldMangaId = newMangaId;
                                string nameManga = reader.GetString(reader.GetOrdinal("Name"));
                                string creator = reader.GetString(reader.GetOrdinal("Creator"));
                                int nrChapters = reader.GetInt32(reader.GetOrdinal("NrChapters"));
                                int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string status = reader.GetString(reader.GetOrdinal("Status"));
                                decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                                MangaStatus statusManga = (MangaStatus)Enum.Parse(typeof(MangaStatus), status);

                                List<Genre> genres = new List<Genre>();
                                string genreManga = reader.GetString(reader.GetOrdinal("Genre"));
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreManga);
                                genres.Add(genre);
                                manga = new Manga(oldMangaId, nameManga, description, rating, releaseYear, imageURL, statusManga, nrChapters, creator, genres);
                                mangaList.Add(manga);
                            }
                            else if (newMangaId == oldMangaId)
                            {
                                string genreManga = reader.GetString(9);
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreManga);
                                manga.AddGenre(genre);
                            }
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
            return mangaList;
        }
    }
}
