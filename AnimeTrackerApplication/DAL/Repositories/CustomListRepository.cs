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
    }
}
