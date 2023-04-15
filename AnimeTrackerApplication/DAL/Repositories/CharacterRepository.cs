using Logic.Animes;
using Logic.Characters;
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
    public class CharacterRepository : BaseDAL
    {
        public void AddCharacter(Character character)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"INSERT INTO Character (Name, Gender, AnimeId, MangaId, Image, NrLikes, NrDislikes) VALUES (@Name, @Gender, @AnimeId, @MangaId, @Image, @NrLikes, @NrDislikes)";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@Name", character.Name);
                            command.Parameters.AddWithValue("@Gender", character.Gender);

                            if(character.FromAnime != null)
                                command.Parameters.AddWithValue("@AnimeId", character.FromAnime);
                            else
                                command.Parameters.AddWithValue("@AnimeId", DBNull.Value);

                            if (character.FromAnime != null)
                                command.Parameters.AddWithValue("@MangaId", character.FromManga);
                            else
                                command.Parameters.AddWithValue("@MangaId", DBNull.Value);
                            
                            command.Parameters.AddWithValue("@Image", character.Image);
                            command.Parameters.AddWithValue("@NrLikes", character.NrLikes);
                            command.Parameters.AddWithValue("@NrDislikes", character.NrDislikes);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Character couldn't be added: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }

        public List<Character> GetAllCharacters()
        {
            List<Character> listCharacters = new List<Character>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Character";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            int characterId = reader.GetInt32(reader.GetOrdinal("CharacterId"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string gender = reader.GetString(reader.GetOrdinal("Gender"));
                            string image = reader.GetString(reader.GetOrdinal("Image"));
                            int nrLikes = reader.GetInt32(reader.GetOrdinal("NrLikes"));
                            int nrDislikes = reader.GetInt32(reader.GetOrdinal("NrDislikes"));
                            Character character = new Character(characterId, name, gender, image, nrLikes, nrDislikes);
                            listCharacters.Add(character);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the characters!");
            }
            return listCharacters;
        }

        public void UpdateCharacter(Character character)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"UPDATE Anime SET Name=@Name, Gender=@Gender, Image=@Image, AnimeId=@AnimeId, MangaId=@MangaId, NrLikes=@NrLikes, NrDislikes=@NrDislikes";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@CharacterId", character.Id);
                            command.Parameters.AddWithValue("@Name", character.Name);
                            command.Parameters.AddWithValue("@Gender", character.Gender);
                            command.Parameters.AddWithValue("@Image", character.Image);
                            if (character.FromAnime != null)
                                command.Parameters.AddWithValue("@AnimeId", character.FromAnime);
                            else
                                command.Parameters.AddWithValue("@AnimeId", DBNull.Value);

                            if (character.FromAnime != null)
                                command.Parameters.AddWithValue("@MangaId", character.FromManga);
                            else
                                command.Parameters.AddWithValue("@MangaId", DBNull.Value);

                            command.Parameters.AddWithValue("@Image", character.Image);
                            command.Parameters.AddWithValue("@NrLikes", character.NrLikes);
                            command.Parameters.AddWithValue("@NrDislikes", character.NrDislikes);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Character couldn't be updated: {ex.Message}");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }

        public void DeleteCharacter(int characterId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query = @"DELETE FROM Character WHERE CharacterId=@CharacterId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@CharacterId", characterId);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Character couldn't be deleted: {ex.Message}");
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
