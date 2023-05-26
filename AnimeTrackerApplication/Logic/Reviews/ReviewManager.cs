using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Reviews
{
    public class ReviewManager : IReviewRepository
    {
        private readonly IReviewRepository reviewRepository;

        public ReviewManager(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }

        public void AddReview(Review review)
        {
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
