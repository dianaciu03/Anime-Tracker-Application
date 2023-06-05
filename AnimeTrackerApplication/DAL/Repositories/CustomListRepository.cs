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
    public class CustomListRepository : BaseDAL, ICustomListRepository
    {
        public void AddContentToList(object content, int listId, string contentType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        switch (contentType)
                        {
                            case "Anime":
                                string query1 = @"INSERT INTO List_Anime (ListId, AnimeId)
                                          VALUES (@ListId, @AnimeId);";
                                using (SqlCommand animeCommand = new SqlCommand(query1, conn, transaction))
                                {
                                    animeCommand.Parameters.AddWithValue("@ListId", listId);
                                    Anime anime = (Anime)content;
                                    animeCommand.Parameters.AddWithValue("@AnimeId", anime.Id);
                                    animeCommand.ExecuteNonQuery();
                                }
                                break;

                            case "Manga":
                                string query2 = @"INSERT INTO List_Manga (ListId, MangaId)
                                          VALUES (@ListId, @MangaId);";
                                using (SqlCommand mangaCommand = new SqlCommand(query2, conn, transaction))
                                {
                                    mangaCommand.Parameters.AddWithValue("@ListId", listId);
                                    Manga manga = (Manga)content;
                                    mangaCommand.Parameters.AddWithValue("@MangaId", manga.Id);
                                    mangaCommand.ExecuteNonQuery();
                                }
                                break;

                            case "Character":
                                string query3 = @"INSERT INTO List_Character (ListId, CharacterId)
                                          VALUES (@ListId, @CharacterId);";
                                using (SqlCommand characterCommand = new SqlCommand(query3, conn, transaction))
                                {
                                    characterCommand.Parameters.AddWithValue("@ListId", listId);
                                    Character character = (Character)content;
                                    characterCommand.Parameters.AddWithValue("@CharacterId", character.Id);
                                    characterCommand.ExecuteNonQuery();
                                }
                                break;
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

        public void DeleteContentFromList(object content, int listId, string contentType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        switch (contentType)
                        {
                            case "Anime":
                                string query1 = @"DELETE FROM List_Anime WHERE ListId=@ListId AND AnimeId=@AnimeId";
                                using (SqlCommand animeCommand = new SqlCommand(query1, conn, transaction))
                                {
                                    animeCommand.Parameters.AddWithValue("@ListId", listId);
                                    Anime anime = (Anime)content;
                                    animeCommand.Parameters.AddWithValue("@AnimeId", anime.Id);
                                    animeCommand.ExecuteNonQuery();
                                }
                                break;

                            case "Manga":
                                string query2 = @"DELETE FROM List_Manga WHERE ListId=@ListId AND MangaId=@MangaId";
                                using (SqlCommand mangaCommand = new SqlCommand(query2, conn, transaction))
                                {
                                    mangaCommand.Parameters.AddWithValue("@ListId", listId);
                                    Manga manga = (Manga)content;
                                    mangaCommand.Parameters.AddWithValue("@MangaId", manga.Id);
                                    mangaCommand.ExecuteNonQuery();
                                }
                                break;

                            case "Character":
                                string query3 = @"DELETE FROM List_Character WHERE ListId=@ListId AND CharacterId=@CharacterId";
                                using (SqlCommand characterCommand = new SqlCommand(query3, conn, transaction))
                                {
                                    characterCommand.Parameters.AddWithValue("@ListId", listId);
                                    Character character = (Character)content;
                                    characterCommand.Parameters.AddWithValue("@CharacterId", character.Id);
                                    characterCommand.ExecuteNonQuery();
                                }
                                break;
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

        public List<CustomList> GetAnimeListByProfileId(int id)
        {
            List<CustomList> animeLists = new List<CustomList>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM CustomList WHERE ProfileId=@ProfileId AND ContentType='Anime'";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ProfileId", id);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int listId = reader.GetInt32(reader.GetOrdinal("ListId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string contentType = reader.GetString(reader.GetOrdinal("ContentType"));
                            CustomList animeList = new CustomList(listId, name, contentType);
                            animeLists.Add(animeList);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the anime lists!");
            }
            return animeLists;
        }

        public CustomList GetCharacterFavouritesByProfileId(int id)
        {
            CustomList likedCharacters = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM CustomList WHERE ProfileId=@ProfileId AND Name='Favourite characters' AND ContentType='Character'";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ProfileId", id);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int listId = reader.GetInt32(reader.GetOrdinal("ListId"));
                            likedCharacters = new CustomList(listId, "Favourite characters", "Character");
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the favourite characters lists!");
            }
            return likedCharacters;
        }

        public List<CustomList> GetMangaListByProfileId(int id)
        {
            List<CustomList> mangaLists = new List<CustomList>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query = @"SELECT * FROM CustomList WHERE ProfileId=@ProfileId AND ContentType='Manga'";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ProfileId", id);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int listId = reader.GetInt32(reader.GetOrdinal("ListId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string contentType = reader.GetString(reader.GetOrdinal("ContentType"));
                            CustomList mangaList = new CustomList(listId, name, contentType);
                            mangaLists.Add(mangaList);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the manga lists!");
            }
            return mangaLists;
        }
    }
}
