using Logic.Animes;
using Logic.Characters;
using Logic.Enums;
using Logic.Mangas;
using Logic.Profiles;
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

        public Profile GetProfileById(int id)
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
                                     WHERE Profile.ProfileId=@ProfileId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ProfileId", id);
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
                throw new Exception("There were issues while trying to retrieve the profile!");
            }
            return profile;
        }
    }
}
