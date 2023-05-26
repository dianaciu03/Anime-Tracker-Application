using Logic.Reviews;

namespace Logic.Reviews
{
    public interface IReviewRepository
    {
        void AddReview(Review review);
        void DeleteReview(int reviewId);
        List<Review> GetAllReviews();
        List<Review> GetReviewsByUserId(int profileId);
    }
}