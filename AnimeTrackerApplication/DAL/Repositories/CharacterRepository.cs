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
                    string query1 = @$"SELECT * FROM Character INNER JOIN ANIME ON Character.AnimeId = Anime.AnimeId INNER JOIN Manga ON Character.MangaId = Manga.MangaId";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        while (reader.Read())
                        {
                            Content anime;
                            Content manga;
                            int? animeId = reader.IsDBNull(reader.GetOrdinal("AnimeId")) ? null : reader.GetInt32(reader.GetOrdinal("AnimeId"));
                            if(animeId != null)
                            {
                                //create anime
                                string nameAnime = reader.GetString(reader.GetOrdinal("Name"));
                                string studio = reader.GetString(reader.GetOrdinal("Studio"));
                                int nrEpisodes = reader.GetInt32(reader.GetOrdinal("NrEpisodes"));
                                int releaseYearAnime = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string releaseSeason = reader.GetString(reader.GetOrdinal("ReleaseSeason"));
                                decimal ratingAnime = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string descriptionAnime = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURLAnime = reader.GetString(reader.GetOrdinal("Image"));
                                Season season = (Season)Enum.Parse(typeof(Season), releaseSeason);
                                anime = new Anime((int)animeId, nameAnime, descriptionAnime, ratingAnime, releaseYearAnime, imageURLAnime, season, nrEpisodes, studio, new List<Genre>());
                            }

                            int? mangaId = reader.IsDBNull(reader.GetOrdinal("MangaId")) ? null : reader.GetInt32(reader.GetOrdinal("MangaId"));
                            if (mangaId != null)
                            {
                                //create manga
                                string nameManga = reader.GetString(reader.GetOrdinal("Name"));
                                string creator = reader.GetString(reader.GetOrdinal("Creator"));
                                int nrChapters = reader.GetInt32(reader.GetOrdinal("NrChapters"));
                                int releaseYearManga = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                                string status = reader.GetString(reader.GetOrdinal("Status"));
                                decimal ratingManga = reader.GetDecimal(reader.GetOrdinal("Rating"));
                                string descriptionManga = reader.GetString(reader.GetOrdinal("Description"));
                                string imageURLManga = reader.GetString(reader.GetOrdinal("Image"));
                                MangaStatus statusManga = (MangaStatus)Enum.Parse(typeof(MangaStatus), status);
                                manga = new Manga((int)mangaId, nameManga, descriptionManga, ratingManga, releaseYearManga, imageURLManga, statusManga, nrChapters, creator, new List<Genre>());
                            }
                            


                            int characterId = reader.GetInt32(reader.GetOrdinal("CharacterId"));
                            string nameCharacter = reader.GetString(reader.GetOrdinal("Name"));
                            string gender = reader.GetString(reader.GetOrdinal("Gender"));

                            
                            listCharacters.Add((Character)character);
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
    }
}
