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
        private ReviewDataValidator rdv;

        public ReviewManager(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
            rdv = new ReviewDataValidator();
        }

        public void AddReview(int profileId, int rating, string description, int contentId, string contentType, DateTime date)
        {
            try
            {
                if (rdv.IsRatingValid(rating.ToString()) && rdv.IsDescriptionValid(description))
                {
                    Review review = new Review(profileId, rating, description, contentId, contentType, date);
                    reviewRepository.AddReview(review);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void DeleteReview(int reviewId)
        {
            reviewRepository.DeleteReview(reviewId);
        }
        public List<Review> GetAllReviews(string cType)
        {
            return reviewRepository.GetAllReviews(cType);
        }
        public List<Review> GetReviewsByUserId(int profileId)
        {
            return reviewRepository.GetReviewsByUserId(profileId);
        }

        public string CalculateTimeAgo(DateTime postDate)
        {
            TimeSpan timeElapsed = DateTime.Now - postDate;

            if (timeElapsed.TotalSeconds < 60)
            {
                return $"{timeElapsed.Seconds} seconds ago";
            }
            else if (timeElapsed.TotalMinutes < 60)
            {
                return $"{timeElapsed.Minutes} minutes ago";
            }
            else if (timeElapsed.TotalHours < 24)
            {
                return $"{timeElapsed.Hours} hours ago";
            }
            else if (timeElapsed.TotalDays < 30)
            {
                int days = (int)timeElapsed.TotalDays;
                return $"{days} {(days == 1 ? "day" : "days")} ago";
            }
            else if (timeElapsed.TotalDays < 365)
            {
                int months = (int)(timeElapsed.TotalDays / 30);
                return $"{months} {(months == 1 ? "month" : "months")} ago";
            }
            else
            {
                int years = (int)(timeElapsed.TotalDays / 365);
                return $"{years} {(years == 1 ? "year" : "years")} ago";
            }
        }

        public Review GetReviewById(int id)
        {
            return reviewRepository.GetReviewById(id);
        }

        public void UpdateReview(int ratingRev, string descriptionRev, int revId)
        {
            reviewRepository.UpdateReview(ratingRev, descriptionRev, revId);
        }
    }
}
