using Logic.Reviews;

namespace Logic.Reviews
{
    public interface IReviewRepository
    {
        void AddReview(Review review);
        void DeleteReview(int reviewId);
        List<Review> GetAllReviews(string cType);
        List<Review> GetReviewsByUserId(int profileId);
        Review GetReviewById(int id);
        void UpdateReview(int ratingRev, string descriptionRev, int revId);
        Dictionary<Review, string> GetSearchedReviews(int cRating, string cType);
    }
}