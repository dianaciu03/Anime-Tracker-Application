using Logic.Animes;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestAnimeDataValidator
    {
        private readonly AnimeDataValidator adv;

        public TestAnimeDataValidator()
        {
            adv = new AnimeDataValidator();
        }

        [Fact]
        public void IsNameValid_ShouldReturnTrue_WhenNameIsProvided()
        {
            // Arrange
            string name = "MyAnimeName";

            // Act
            bool result = adv.IsNameValid(name);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNameValid_ShouldThrowException_WhenNameIsInvalid()
        {
            // Arrange
            string name = null;

            // Act & Assert
            Assert.Throws<Exception>(() => adv.IsNameValid(name));
        }

        [Fact]
        public void IsStudioValid_ShouldReturnTrue_WhenNameIsProvided()
        {
            // Arrange
            string studio = "MyAnimeStudio";

            // Act
            bool result = adv.IsStudioValid(studio);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsStudioValid_ShouldThrowException_WhenStudioIsInvalid()
        {
            // Arrange
            string studio = null;

            // Act & Assert
            Assert.Throws<Exception>(() => adv.IsStudioValid(studio));
        }

        [Fact]
        public void IsDescriptionValid_ShouldReturnTrue_WhenDescriptionIsProvided()
        {
            // Arrange
            string description = "MyAnimeDescription";

            // Act
            bool result = adv.IsDescriptionValid(description);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDescriptionValid_ShouldThrowException_WhenDescriptionIsInvalid()
        {
            // Arrange
            string description = null;

            // Act & Assert
            Assert.Throws<Exception>(() => adv.IsDescriptionValid(description));
        }

        [Fact]
        public void IsNrEpisodesValid_ShouldReturnTrue_WhenNrEpisodesAreProvided()
        {
            // Arrange
            string nrEpisodes = "24";

            // Act
            bool result = adv.IsNrEpisodesValid(nrEpisodes);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNrEpisodesValid_ShouldThrowException_WhenNrEpisodesAreInvalid()
        {
            // Arrange
            string nrEpisodes = "notANumber";

            // Act & Assert
            Assert.Throws<Exception>(() => adv.IsNrEpisodesValid(nrEpisodes));
        }

        [Fact]
        public void IsRatingValid_ShouldReturnTrue_WhenRatingIsProvided()
        {
            // Arrange
            string rating = "4.5";

            // Act
            bool result = adv.IsRatingValid(rating);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsRatingValid_ShouldThrowException_WhenRatingIsInvalid()
        {
            // Arrange
            string rating = "12";

            // Act & Assert
            Assert.Throws<Exception>(() => adv.IsRatingValid(rating));
        }

        [Fact]
        public void IsYearValid_ShouldReturnTrue_WhenYearIsProvided()
        {
            // Arrange
            string year = "2003";

            // Act
            bool result = adv.IsYearValid(year);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsYearValid_ShouldThrowException_WhenYearIsInvalid()
        {
            // Arrange
            string rating = "1000";

            // Act & Assert
            Assert.Throws<Exception>(() => adv.IsYearValid(rating));
        }

        [Fact]
        public void IsImageURLValid_ShouldReturnTrue_WhenImageURLIsProvided()
        {
            // Arrange
            string image = "https://upload.wikimedia.org/wikipedia/en/8/81/Modernanime.jpg";

            // Act
            bool result = adv.IsValidImageUrl(image);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsImageURLValid_ShouldThrowException_WhenImageURLIsInvalid()
        {
            // Arrange
            string image = "notAValidLink.com";

            // Act & Assert
            Assert.Throws<Exception>(() => adv.IsValidImageUrl(image));
        }
    }
}
