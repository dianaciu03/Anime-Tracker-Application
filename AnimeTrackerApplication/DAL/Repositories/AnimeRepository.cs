using Logic.Animes;
using Logic.Contents;
using Logic.Enums;
using Logic.Users;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace DAL.Repositories
{
    public class AnimeRepository : BaseDAL, IAnimeRepository
    {
        public List<Anime> GetAllAnime(string sortBy, bool ascending)
        {
            List<Anime> listAnime = new List<Anime>();
            int oldAnimeId = 0;
            Content anime = new Anime();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string sortDirection = ascending ? "ASC" : "DESC";
                    string query1 = @$"SELECT Anime.*, ContentGenre.Genre FROM Anime INNER JOIN Anime_Genre 
                                       ON Anime.AnimeId = Anime_Genre.AnimeId INNER JOIN ContentGenre 
                                       ON Anime_Genre.GenreId = ContentGenre.GenreId
                                       ORDER BY {sortBy} {sortDirection}";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            int newAnimeId = reader.GetInt32(reader.GetOrdinal("AnimeId"));
                            if(newAnimeId != oldAnimeId)
                            {
                                oldAnimeId = newAnimeId;

                                string name = reader.GetString(reader.GetOrdinal("Name"));
                                string studio = reader.GetString(reader.GetOrdinal("Studio"));
                                int nrEpisodes = reader.GetInt32(reader.GetOrdinal("NrEpisodes"));
                                int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string releaseSeason = reader.GetString(reader.GetOrdinal("ReleaseSeason"));
                                decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                                Season season = (Season)Enum.Parse(typeof(Season), releaseSeason);

                                List<Genre> genres = new List<Genre>();
                                string genreAnime = reader.GetString(reader.GetOrdinal("Genre"));
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreAnime);
                                genres.Add(genre);
                                anime = new Anime(oldAnimeId, name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
                                listAnime.Add((Anime)anime);
                            }
                            else if(newAnimeId == oldAnimeId)
                            {
                                string genreAnime = reader.GetString(9);
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreAnime);
                                anime.AddGenre(genre);
                            }
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
                        string query1 = @"INSERT INTO Anime (Name, Studio, NrEpisodes, ReleaseYear, ReleaseSeason, Rating, Description, Image)
                                          VALUES (@Name, @Studio, @NrEpisodes, @ReleaseYear, @ReleaseSeason, @Rating, @Description, @Image);
                                          SELECT SCOPE_IDENTITY();";
                        int animeId = 0;
                        using (SqlCommand animeCommand = new SqlCommand(query1, conn, transaction))
                        {
                            animeCommand.Parameters.AddWithValue("@Name", anime.Name);
                            animeCommand.Parameters.AddWithValue("@Studio", anime.Studio);
                            animeCommand.Parameters.AddWithValue("@NrEpisodes", anime.NrEpisodes);
                            animeCommand.Parameters.AddWithValue("@ReleaseYear", anime.ReleaseYear);
                            animeCommand.Parameters.AddWithValue("@ReleaseSeason", anime.SeasonAnime.ToString());
                            animeCommand.Parameters.AddWithValue("@Rating", anime.Rating);
                            animeCommand.Parameters.AddWithValue("@Description", anime.Description);
                            animeCommand.Parameters.AddWithValue("@Image", anime.ImageURL);
                            animeId = Convert.ToInt32(animeCommand.ExecuteScalar());
                        }

                        foreach(Genre genre in anime.GetGenres())
                        {
                            string query2 = @"INSERT INTO Anime_Genre (AnimeId, GenreId)
                                        VALUES (@AnimeId, (SELECT GenreId FROM ContentGenre WHERE Genre = @Genre))";
                            using (SqlCommand genreCommand = new SqlCommand(query2, conn, transaction))
                            {
                                genreCommand.Parameters.Clear();
                                genreCommand.Parameters.AddWithValue("@AnimeId", animeId);
                                genreCommand.Parameters.AddWithValue("@Genre", genre.ToString());
                                genreCommand.ExecuteNonQuery();
                            }      
                        }

                        transaction.Commit();
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

        public void UpdateAnime(Anime anime)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query1 = @"DELETE FROM Anime_Genre WHERE AnimeId=@AnimeId";
                        using (SqlCommand command = new SqlCommand(query1, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@AnimeId", anime.Id);
                            command.ExecuteNonQuery();
                        }

                        string query2 = @"UPDATE Anime SET Name=@Name, Studio=@Studio, NrEpisodes=@NrEpisodes, ReleaseYear=@ReleaseYear, ReleaseSeason=@ReleaseSeason, Rating=@Rating, Description=@Description, Image=@Image WHERE AnimeId=@AnimeId";
                        using (SqlCommand command = new SqlCommand(query2, conn, transaction))
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
                        }

                        foreach (Genre genre in anime.GetGenres())
                        {
                            string query3 = @"INSERT INTO Anime_Genre (AnimeId, GenreId)
                                        VALUES (@AnimeId, (SELECT GenreId FROM ContentGenre WHERE Genre = @Genre))";
                            using (SqlCommand genreCommand = new SqlCommand(query3, conn, transaction))
                            {
                                genreCommand.Parameters.Clear();
                                genreCommand.Parameters.AddWithValue("@AnimeId", anime.Id);
                                genreCommand.Parameters.AddWithValue("@Genre", genre.ToString());
                                genreCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
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

        public void DeleteAnime(int animeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query2 = @"DELETE FROM Anime_Genre WHERE AnimeId=@AnimeId";
                        using (SqlCommand command = new SqlCommand(query2, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@AnimeId", animeId);
                            command.ExecuteNonQuery();
                        }

                        string query1 = @"DELETE FROM Anime WHERE AnimeId=@AnimeId";
                        using (SqlCommand command = new SqlCommand(query1, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@AnimeId", animeId);
                            command.ExecuteNonQuery();   
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Anime couldn't be deleted: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }

        public Anime? GetAnimeById(int animeId)
        {
            Anime anime = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT Anime.*, ContentGenre.Genre FROM Anime INNER JOIN Anime_Genre 
                                     ON Anime.AnimeId = Anime_Genre.AnimeId INNER JOIN ContentGenre 
                                     ON Anime_Genre.GenreId = ContentGenre.GenreId WHERE Anime.AnimeId=@AnimeId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@AnimeId", animeId);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            if (anime == null) 
                            {
                                string name = reader.GetString(reader.GetOrdinal("Name"));
                                string studio = reader.GetString(reader.GetOrdinal("Studio"));
                                int nrEpisodes = reader.GetInt32(reader.GetOrdinal("NrEpisodes"));
                                int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string releaseSeason = reader.GetString(reader.GetOrdinal("ReleaseSeason"));
                                decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                                Season season = (Season)Enum.Parse(typeof(Season), releaseSeason);

                                List<Genre> genres = new List<Genre>();
                                string genreAnime = reader.GetString(reader.GetOrdinal("Genre"));
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreAnime);
                                genres.Add(genre);
                                anime = new Anime(animeId, name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
                            }
                            else
                            {
                                string genreAnimeNext = reader.GetString(9);
                                Genre genreNext = (Genre)Enum.Parse(typeof(Genre), genreAnimeNext);
                                anime.AddGenre(genreNext);
                            }  
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the anime!");
            }
            return anime;
        }

        public List<Anime> GetAnimeByName(string name)
        {
            List<Anime> animeList = new List<Anime>();
            Anime anime = null;
            int oldAnimeId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT Anime.*, ContentGenre.Genre FROM Anime INNER JOIN Anime_Genre 
                                       ON Anime.AnimeId = Anime_Genre.AnimeId INNER JOIN ContentGenre 
                                       ON Anime_Genre.GenreId = ContentGenre.GenreId
                                       WHERE Name LIKE '%' + @Name + '%' ";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int newAnimeId = reader.GetInt32(reader.GetOrdinal("AnimeId"));
                            if (newAnimeId != oldAnimeId)
                            {
                                oldAnimeId = newAnimeId;

                                string nameAnime = reader.GetString(reader.GetOrdinal("Name"));
                                string studio = reader.GetString(reader.GetOrdinal("Studio"));
                                int nrEpisodes = reader.GetInt32(reader.GetOrdinal("NrEpisodes"));
                                int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string releaseSeason = reader.GetString(reader.GetOrdinal("ReleaseSeason"));
                                decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                                Season season = (Season)Enum.Parse(typeof(Season), releaseSeason);

                                List<Genre> genres = new List<Genre>();
                                string genreAnime = reader.GetString(reader.GetOrdinal("Genre"));
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreAnime);
                                genres.Add(genre);
                                anime = new Anime(oldAnimeId, nameAnime, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
                                animeList.Add(anime);
                            }
                            else if (newAnimeId == oldAnimeId)
                            {
                                string genreAnime = reader.GetString(9);
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreAnime);
                                anime.AddGenre(genre);
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the anime!");
            }
            return animeList;
        }

        public List<Anime> GetSearchedAnime(string nameA, string studioA, int nrEpFromA, int nrEpToA, string releaseYearA, string releaseSeasonA, string genreA, decimal ratingFromA, decimal ratingToA)
        {
            List<Anime> animeList = new List<Anime>();
            Anime anime = null;
            int oldAnimeId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT Anime.*, ContentGenre.Genre FROM Anime INNER JOIN Anime_Genre 
                                       ON Anime.AnimeId = Anime_Genre.AnimeId INNER JOIN ContentGenre 
                                       ON Anime_Genre.GenreId = ContentGenre.GenreId
                                       WHERE Name LIKE '%' + @Name + '%' 
                                       AND Studio LIKE '%' + @Studio + '%' 
                                       AND NrEpisodes >= @NrEpisodesFrom AND NrEpisodes <= @NrEpisodesTo 
                                       AND ReleaseYear LIKE '%' + @ReleaseYear + '%' 
                                       AND ReleaseSeason LIKE '%' + @ReleaseSeason + '%'
                                       AND Genre LIKE '%' + @Genre + '%' 
                                       AND Rating >= @RatingFrom AND Rating <= @RatingTo";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", nameA);
                        command.Parameters.AddWithValue("@Studio", studioA);
                        command.Parameters.AddWithValue("@NrEpisodesFrom", nrEpFromA);
                        command.Parameters.AddWithValue("@NrEpisodesTo", nrEpToA);
                        command.Parameters.AddWithValue("@ReleaseYear", releaseYearA);
                        command.Parameters.AddWithValue("@ReleaseSeason", releaseSeasonA);
                        command.Parameters.AddWithValue("@Genre", genreA);
                        command.Parameters.AddWithValue("@RatingFrom", ratingFromA);
                        command.Parameters.AddWithValue("@RatingTo", ratingToA);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int newAnimeId = reader.GetInt32(reader.GetOrdinal("AnimeId"));
                            if (newAnimeId != oldAnimeId)
                            {
                                oldAnimeId = newAnimeId;

                                string nameAnime = reader.GetString(reader.GetOrdinal("Name"));
                                string studio = reader.GetString(reader.GetOrdinal("Studio"));
                                int nrEpisodes = reader.GetInt32(reader.GetOrdinal("NrEpisodes"));
                                int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string releaseSeason = reader.GetString(reader.GetOrdinal("ReleaseSeason"));
                                decimal rating = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURL = reader.GetString(reader.GetOrdinal("Image"));
                                Season season = (Season)Enum.Parse(typeof(Season), releaseSeason);

                                List<Genre> genres = new List<Genre>();
                                string genreAnime = reader.GetString(reader.GetOrdinal("Genre"));
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreAnime);
                                genres.Add(genre);
                                anime = new Anime(oldAnimeId, nameAnime, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, genres);
                                animeList.Add(anime);
                            }
                            else if (newAnimeId == oldAnimeId)
                            {
                                string genreAnime = reader.GetString(9);
                                Genre genre = (Genre)Enum.Parse(typeof(Genre), genreAnime);
                                anime.AddGenre(genre);
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the anime!");
            }
            return animeList;
        }
    }
}
