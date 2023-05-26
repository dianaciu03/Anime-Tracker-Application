using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Reviews
{
    public class ReviewManager : IReviewManager
    {
        private readonly IReviewRepository reviewRepository;

        public ReviewManager(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }

        public void AddReview(int profileId, int rating, string description, int contentId, string contentType, DateTime date)
        {
            Review review = new Review(profileId, rating, description, contentId, contentType, date);
            reviewRepository.AddReview(review);
        }
        public void DeleteReview(int reviewId)
        {
            reviewRepository.DeleteReview(reviewId);
        }
        public List<Review> GetAllReviews()
        {
            return reviewRepository.GetAllReviews();
        }
        public List<Review> GetReviewsByUserId(int profileId)
        {
            return reviewRepository.GetReviewsByUserId(profileId);
        }
    }
}
