using Logic.Animes;
using Logic.Contents;
using Logic.Enums;
using Logic.Profiles;
using Logic.Reviews;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestReviewManager
    {
        private readonly ReviewManager reviewManager;
        private readonly Mock<IReviewRepository> mockReviewRepo;

        public TestReviewManager()
        {
            mockReviewRepo = new Mock<IReviewRepository>();
            reviewManager = new ReviewManager(mockReviewRepo.Object);
        }

        [Fact]
        public void Check_We_Can_Add_Review()
        {
            // Arrange
            int profileId = 23;
            int rating = 5;
            string description = "Some Description";
            int contentId = 2022;
            string contentType = "Anime";
            DateTime date = DateTime.Now;

            // Act
            reviewManager.AddReview(profileId, rating, description, contentId, contentType, date);

            // Assert
            mockReviewRepo.Verify(x => x.AddReview(It.IsAny<Review>()), Times.Once);
        }

        [Fact]
        public void Check_We_Can_Not_Add_Invalid_Review()
        {
            // Arrange
            int profileId = 23;
            int rating = 20;
            string description = "";
            int contentId = 2022;
            string contentType = "Something else";
            DateTime date = DateTime.Now;

            // Act & Assert
            Assert.Throws<Exception>(() =>
            {
                reviewManager.AddReview(profileId, rating, description, contentId, contentType, date);
            });
        }

        [Fact]
        public void CalculateTimeAgo_ShouldReturnTimeAgoString_WhenValidDatesProvided()
        {
            // Arrange
            DateTime postDate = new DateTime(2022, 5, 1);
            DateTime currentDate = new DateTime(2022, 5, 17);

            // Act
            string actualTimeAgo = reviewManager.CalculateTimeAgo(postDate, currentDate);

            // Assert
            Assert.Equal("16 days ago", actualTimeAgo);
        }

        [Fact]
        public void CalculateTimeAgo_ShouldThrowException_WhenCurrentDateIsEarlierThanPostDate()
        {
            // Arrange
            DateTime postDate = new DateTime(2022, 5, 17);
            DateTime currentDate = new DateTime(2022, 5, 1);

            // Act & Assert
            Assert.Throws<Exception>(() =>
            {
                reviewManager.CalculateTimeAgo(postDate, currentDate);
            });
        }
    }
}
