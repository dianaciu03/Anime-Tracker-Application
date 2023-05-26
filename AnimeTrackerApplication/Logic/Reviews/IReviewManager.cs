namespace Logic.Reviews
{
    public interface IReviewManager
    {
        void AddReview(int profileId, int rating, string description, int contentId, string contentType, DateTime date);
        void DeleteReview(int reviewId);
        List<Review> GetAllReviews();
        List<Review> GetReviewsByUserId(int profileId);
    }
}