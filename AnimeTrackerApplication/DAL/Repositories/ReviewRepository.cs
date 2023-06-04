using Logic.Animes;
using Logic.Contents;
using Logic.Enums;
using Logic.Reviews;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ReviewRepository : BaseDAL, IReviewRepository
    {
        public void AddReview(Review review)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query1 = @"INSERT INTO Reviews (ProfileId, Rating, Description, ContentId, ContentType, Date)
                                          VALUES (@ProfileId, @Rating, @Description, @ContentId, @ContentType, @Date)";
                        using (SqlCommand command = new SqlCommand(query1, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@ProfileId", review.ProfileId);
                            command.Parameters.AddWithValue("@Rating", review.Rating);
                            command.Parameters.AddWithValue("@Description", review.Description);
                            command.Parameters.AddWithValue("@ContentId", review.ContentId);
                            command.Parameters.AddWithValue("@ContentType", review.ContentType);
                            command.Parameters.AddWithValue("@Date", review.Date);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception($"Review couldn't be added!");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception($"An error occurred!");
            }
        }

        public void UpdateReview(int ratingRev, string descriptionRev, int revId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query2 = @"UPDATE Reviews SET Rating=@Rating, Description=@Description WHERE ReviewId=@ReviewId";
                        using (SqlCommand command = new SqlCommand(query2, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@ReviewId", revId);
                            command.Parameters.AddWithValue("@Rating", ratingRev);
                            command.Parameters.AddWithValue("@Description", descriptionRev);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception($"Review couldn't be updated!");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception($"An error occurred!");
            }
        }

        public List<Review> GetAllReviews(string cType)
        {
            List<Review> reviews = new List<Review>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Reviews WHERE ContentType = @ContentType";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        command1.Parameters.AddWithValue("@ContentType", cType);
                        SqlDataReader reader = command1.ExecuteReader();
                        while (reader.Read())
                        {
                            int reviewId = reader.GetInt32(reader.GetOrdinal("ReviewId"));
                            int profileId = reader.GetInt32(reader.GetOrdinal("ProfileId"));
                            int rating = reader.GetInt32(reader.GetOrdinal("Rating"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));
                            int contentId = reader.GetInt32(reader.GetOrdinal("ContentId"));
                            string contentType = reader.GetString(reader.GetOrdinal("ContentType"));
                            DateTime date = reader.GetDateTime(reader.GetOrdinal("Date"));

                            Review review = new Review(reviewId, profileId, rating, description, contentId, contentType, date);
                            reviews.Add(review);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the reviews!");
            }
            return reviews;
        }

        public List<Review> GetReviewsByUserId(int profileId)
        {
            List<Review> reviews = new List<Review>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Reviews WHERE ProfileId=@ProfileId";
                    using (SqlCommand command = new SqlCommand(query1, conn))
                    {
                        command.Parameters.AddWithValue("@ProfileId", profileId);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int reviewId = reader.GetInt32(reader.GetOrdinal("ReviewId"));
                            int rating = reader.GetInt32(reader.GetOrdinal("Rating"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));
                            int contentId = reader.GetInt32(reader.GetOrdinal("ContentId"));
                            string contentType = reader.GetString(reader.GetOrdinal("ContentType"));
                            DateTime date = reader.GetDateTime(reader.GetOrdinal("Date"));

                            Review review = new Review(reviewId, profileId, rating, description, contentId, contentType, date);
                            reviews.Add(review);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the reviews!");
            }
            return reviews;
        }

        public Review GetReviewById(int id)
        {
            Review review = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    string query1 = @$"SELECT * FROM Reviews WHERE ReviewId = @ReviewId";
                    using (SqlCommand command1 = new SqlCommand(query1, conn))
                    {
                        command1.Parameters.AddWithValue("@ReviewId", id);
                        SqlDataReader reader = command1.ExecuteReader();
                        while (reader.Read())
                        {
                            int reviewId = reader.GetInt32(reader.GetOrdinal("ReviewId"));
                            int profileId = reader.GetInt32(reader.GetOrdinal("ProfileId"));
                            int rating = reader.GetInt32(reader.GetOrdinal("Rating"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));
                            int contentId = reader.GetInt32(reader.GetOrdinal("ContentId"));
                            string contentType = reader.GetString(reader.GetOrdinal("ContentType"));
                            DateTime date = reader.GetDateTime(reader.GetOrdinal("Date"));

                            review = new Review(reviewId, profileId, rating, description, contentId, contentType, date);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrive the reviews!");
            }
            return review;
        }

        public void DeleteReview(int reviewId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string query2 = @"DELETE FROM Reviews WHERE ReviewId=@ReviewId";
                        using (SqlCommand command = new SqlCommand(query2, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@ReviewId", reviewId);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception($"Review couldn't be deleted!");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception($"An error occurred!");
            }
        }
    }
}
