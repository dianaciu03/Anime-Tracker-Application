using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using IdividualLogicLayer;
using System.Reflection.Metadata;

namespace IndividualDAL
{
    public class AnimeDAL : BaseDAL
    {

        public List<Content> GetAllAnime()
        {
            List<Content> listAnime = new List<Content>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Anime";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        SqlDataReader reader = command1.ExecuteReader();

                        if (!reader.Read())
                        {
                            reader.Close();
                            conn.Close();
                            return listAnime;
                        }

                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string studio = reader.GetString(reader.GetOrdinal("Studio"));
                            int nrEpisodes = reader.GetInt32(reader.GetOrdinal("NrEpisodes"));
                            int releaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                            string releaseSeason = reader.GetString(reader.GetOrdinal("ReleaseSeason"));
                            double rating = reader.GetDouble(reader.GetOrdinal("Rating"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));
                            string imageURL = reader.GetString(reader.GetOrdinal("Image"));

                            Season season = (Season)Enum.Parse(typeof(Season), releaseSeason);

                            Content anime = new Anime(name, description, rating, releaseYear, imageURL, season, nrEpisodes, studio, new List<Genre>());
                            listAnime.Add(anime);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("There are no anime at the moment");
            }
            return listAnime;
        }
            
            

        public void AddAnime(Anime anime)
        {

        }

        public void UpdateAnime(Anime anime)
        {

        }

        public void DeleteAnime(Anime anime)
        {

        }
    }
}
