using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Animes;

namespace Logic.Reviews
{
    public class Review 
    {
        private int reviewId;
        private int contentId;
        private string contentType;
        private int profileId;
        private int rating;
        private string description;

        public Review() { }
        public Review(int reviewId, int contentId, int profileId, int rating, string description, string contentType)
        {
            this.reviewId = reviewId;
            this.contentId = contentId;
            this.profileId = profileId;
            this.rating = rating;
            this.description = description;
            this.contentType = contentType;
        }
        public Review(int contentId, int profileId, int rating, string description, string contentType)
        {
            this.contentId = contentId;
            this.profileId = profileId;
            this.rating = rating;
            this.description = description;
            this.contentType = contentType;
        }

        public int Id { get { return reviewId; } set { this.reviewId = value; } }
        public int ContentId { get { return contentId; } set { this.contentId = value; } }
        public int ProfileId { get { return profileId; } set { this.profileId = value; } }
        public string ContentType { get { return contentType; } set { this.contentType = value; } }
        public int Rating { get { return rating; } set { this.rating = value; } }
        public string Description { get { return description; } set { this.description = value; } }
    }
}
