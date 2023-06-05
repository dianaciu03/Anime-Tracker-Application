using Logic.Enums;
using Logic.Mangas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestMangaDataValidator
    {
        private readonly MangaDataValidator mdv;

        public TestMangaDataValidator()
        {
            mdv = new MangaDataValidator();
        }

        [Fact]
        public void IsNameValid_ShouldReturnTrue_WhenNameIsProvided()
        {
            // Arrange
            string name = "MyAnimeName";

            // Act
            bool result = mdv.IsNameValid(name);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsCreatorValid_ShouldReturnTrue_WhenCreatorIsProvided()
        {
            // Arrange
            string creator = "John Doe";

            // Act
            bool result = mdv.IsCreatorValid(creator);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDescriptionValid_ShouldReturnTrue_WhenDescriptionIsProvided()
        {
            // Arrange
            string description = "This is the anime description";

            // Act
            bool result = mdv.IsDescriptionValid(description);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNrChaptersValid_ShouldReturnTrue_WhenNrChaptersIsValid()
        {
            // Arrange
            string nrChapters = "10";

            // Act
            bool result = mdv.IsNrChaptersValid(nrChapters);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsRatingValid_ShouldReturnTrue_WhenRatingIsValid()
        {
            // Arrange
            string rating = "4.5";

            // Act
            bool result = mdv.IsRatingValid(rating);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsYearValid_ShouldReturnTrue_WhenYearIsValid()
        {
            // Arrange
            string year = "2022";

            // Act
            bool result = mdv.IsYearValid(year);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsStatusValid_ShouldReturnTrue_WhenStatusIsValid()
        {
            // Arrange
            MangaStatus status = MangaStatus.Ongoing;

            // Act
            bool result = mdv.IsStatusValid(status);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidImageUrl_ShouldReturnTrue_WhenImageUrlIsValid()
        {
            // Arrange
            string url = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Wikipe-tan_manga_page1.jpg/220px-Wikipe-tan_manga_page1.jpg";

            // Act
            bool result = mdv.IsValidImageUrl(url);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNameValid_ShouldThrowException_WhenNameIsNotProvided()
        {
            // Arrange
            string name = "";

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsNameValid(name));
        }

        [Fact]
        public void IsCreatorValid_ShouldThrowException_WhenCreatorIsNotProvided()
        {
            // Arrange
            string creator = "";

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsCreatorValid(creator));
        }

        [Fact]
        public void IsDescriptionValid_ShouldThrowException_WhenDescriptionIsNotProvided()
        {
            // Arrange
            string description = "";

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsDescriptionValid(description));
        }

        [Fact]
        public void IsNrChaptersValid_ShouldThrowException_WhenNrChaptersIsNotValid()
        {
            // Arrange
            string nrChapters = "0";

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsNrChaptersValid(nrChapters));
        }

        [Fact]
        public void IsRatingValid_ShouldThrowException_WhenRatingIsNotValid()
        {
            // Arrange
            string rating = "6.0";

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsRatingValid(rating));
        }

        [Fact]
        public void IsYearValid_ShouldThrowException_WhenYearIsNotValid()
        {
            // Arrange
            string year = "1800";

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsYearValid(year));
        }

        [Fact]
        public void IsStatusValid_ShouldThrowException_WhenStatusIsNotValid()
        {
            // Arrange
            MangaStatus status = (MangaStatus)99;

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsStatusValid(status));
        }

        [Fact]
        public void IsValidImageUrl_ShouldThrowException_WhenImageUrlIsNotValid()
        {
            // Arrange
            string url = "https://example.com/invalid_image";

            // Act & Assert
            Assert.Throws<Exception>(() => mdv.IsValidImageUrl(url));
        }
    }

}
