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
        private int profileId;
        private int rating;
        private string description;

        public Review() { }
        public Review(int reviewId, int contentId, int profileId, int rating, string description)
        {
            this.reviewId = reviewId;
            this.contentId = contentId;
            this.profileId = profileId;
            this.rating = rating;
            this.description = description;
        }
        public Review(int contentId, int profileId, int rating, string description)
        {
            this.contentId = contentId;
            this.profileId = profileId;
            this.rating = rating;
            this.description = description;
        }

    }
}
