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
    public class CharacterRepository : BaseDAL, ICharacterRepository
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

                            if (character.FromAnime != null)
                                command.Parameters.AddWithValue("@AnimeId", character.FromAnime.Id);
                            else
                                command.Parameters.AddWithValue("@AnimeId", DBNull.Value);

                            if (character.FromManga != null)
                                command.Parameters.AddWithValue("@MangaId", character.FromManga.Id);
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
                            int? animeId = reader.IsDBNull(reader.GetOrdinal("AnimeId")) ? null : reader.GetInt32(reader.GetOrdinal("AnimeId"));
                            if(animeId != null)
                            {
                                character.AnimeId = (int)animeId;
                            }
                            int? mangaId = reader.IsDBNull(reader.GetOrdinal("MangaId")) ? null : reader.GetInt32(reader.GetOrdinal("MangaId"));
                            if (mangaId != null)
                            {
                                character.MangaId = (int)mangaId;
                            }
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

        public Character? GetCharacterById(int id)
        {
            Character character = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Character WHERE CharacterId = @CharacterId";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        command1.Parameters.AddWithValue("@CharacterId", id);
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string gender = reader.GetString(reader.GetOrdinal("Gender"));
                            string image = reader.GetString(reader.GetOrdinal("Image"));
                            int nrLikes = reader.GetInt32(reader.GetOrdinal("NrLikes"));
                            int nrDislikes = reader.GetInt32(reader.GetOrdinal("NrDislikes"));
                            character = new Character(id, name, gender, image, nrLikes, nrDislikes);
                            int? animeId = reader.IsDBNull(reader.GetOrdinal("AnimeId")) ? null : reader.GetInt32(reader.GetOrdinal("AnimeId"));
                            if (animeId != null)
                            {
                                character.AnimeId = (int)animeId;
                            }
                            int? mangaId = reader.IsDBNull(reader.GetOrdinal("MangaId")) ? null : reader.GetInt32(reader.GetOrdinal("MangaId"));
                            if (mangaId != null)
                            {
                                character.MangaId = (int)mangaId;
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the character!");
            }
            return character;
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
                        string query = @"UPDATE Character SET Name=@Name, Gender=@Gender, AnimeId=@AnimeId, MangaId=@MangaId, Image=@Image, NrLikes=@NrLikes, NrDislikes=@NrDislikes WHERE CharacterId=@CharacterId";
                        using (SqlCommand command = new SqlCommand(query, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@CharacterId", character.Id);
                            command.Parameters.AddWithValue("@Name", character.Name);
                            command.Parameters.AddWithValue("@Gender", character.Gender);
                            
                            if (character.FromAnime != null)
                            {
                                command.Parameters.AddWithValue("@AnimeId", character.FromAnime.Id);
                            }  
                            else
                            {
                                command.Parameters.AddWithValue("@AnimeId", DBNull.Value);
                            }
                            if (character.FromManga != null)
                            {
                                command.Parameters.AddWithValue("@MangaId", character.FromManga.Id);
                            }   
                            else
                            {
                                command.Parameters.AddWithValue("@MangaId", DBNull.Value);
                            }
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

        public List<Character> GetSearchedCharacters(string nameC, string genderC, List<Anime> animes, List<Manga> mangas)
        {
            List<Character> listCharacters = new List<Character>();
            List<Character> goodCharacters = new List<Character>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Character WHERE Name LIKE '%' + @Name + '%' AND Gender LIKE '%' + @Gender + '%'";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        command1.Parameters.AddWithValue("@Name", nameC);
                        command1.Parameters.AddWithValue("@Gender", genderC);
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
                            int? animeId = reader.IsDBNull(reader.GetOrdinal("AnimeId")) ? null : reader.GetInt32(reader.GetOrdinal("AnimeId"));
                            if (animeId != null)
                            {
                                character.AnimeId = (int)animeId;
                            }
                            int? mangaId = reader.IsDBNull(reader.GetOrdinal("MangaId")) ? null : reader.GetInt32(reader.GetOrdinal("MangaId"));
                            if (mangaId != null)
                            {
                                character.MangaId = (int)mangaId;
                            }
                            listCharacters.Add(character);
                        }
                        reader.Close();

                    }
                    conn.Close();
                }

                if(animes.Count == 0 && mangas.Count == 0)
                {
                    return listCharacters;
                }
                if (animes.Count != 0)
                {
                    foreach (Character character in listCharacters)
                    {
                        foreach (Anime anime in animes)
                        {
                            if (character.AnimeId == anime.Id)
                            {
                                goodCharacters.Add(character);
                            }
                        }
                    }
                }
                if (mangas.Count != 0)
                {
                    foreach (Character character in listCharacters)
                    {
                        foreach (Manga manga in mangas)
                        {
                            if (character.MangaId == manga.Id)
                            {
                                goodCharacters.Add(character);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the characters!");
            }
            return goodCharacters;
        }
    }
}
