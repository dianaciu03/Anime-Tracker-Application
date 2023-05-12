using Logic.Animes;
using Logic.Enums;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class TestAnimeManager
    {
        private readonly AnimeManager animeManager;
        private readonly Mock<IAnimeRepository> mockAnimeRepo;

        public TestAnimeManager()
        {
            mockAnimeRepo = new Mock<IAnimeRepository>();
            animeManager = new AnimeManager(mockAnimeRepo.Object);
        }

        [Fact]
        public void Check_We_Can_Add_Anime()
        {
            // Arrange
            string animeName = "Sample Anime";
            string animeDescription = "This is a sample anime description";
            decimal animeRating = 4.5m;
            int animeReleaseYear = 2022;
            string animeImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/81/Modernanime.jpg";
            Season animeSeason = Season.Autumn;
            int animeNrEpisodes = 12;
            string animeStudio = "Sample Studio";
            List<Genre> animeGenres = new List<Genre>() { Genre.Action, Genre.Comedy };

            // Act
            animeManager.AddAnime(animeName, animeDescription, animeRating, animeReleaseYear, animeImageUrl, animeSeason, animeNrEpisodes, animeStudio, animeGenres);

            // Assert
            mockAnimeRepo.Verify(x => x.AddAnime(It.IsAny<Anime>()), Times.Once);
        }

        [Fact]
        public void Check_We_Can_Not_Add_Invalid_Anime()
        {
            // Arrange
            string animeName = "";
            string animeDescription = "This is a sample anime description";
            decimal animeRating = 4.5m;
            int animeReleaseYear = 2022;
            string animeImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/81/Modernanime.jpg";
            Season animeSeason = Season.Autumn;
            int animeNrEpisodes = -1;
            string animeStudio = "";
            List<Genre> animeGenres = new List<Genre>();

            // Act & Assert
            Assert.Throws<Exception>(() =>
            {
                animeManager.AddAnime(animeName, animeDescription, animeRating, animeReleaseYear, animeImageUrl, animeSeason, animeNrEpisodes, animeStudio, animeGenres);
            });
        }

        [Fact]
        public void Check_We_Can_Update_Anime()
        {
            // Arrange
            int id = 1;
            string animeName = "Sample Anime";
            string animeDescription = "This is a sample anime description";
            decimal animeRating = 4.5m;
            int animeReleaseYear = 2022;
            string animeImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/81/Modernanime.jpg";
            Season animeSeason = Season.Autumn;
            int animeNrEpisodes = 12;
            string animeStudio = "Sample Studio";
            List<Genre> animeGenres = new List<Genre>() { Genre.Action, Genre.Comedy };

            // Act
            animeManager.UpdateAnime(id, animeName, animeDescription, animeRating, animeReleaseYear, animeImageUrl, animeSeason, animeNrEpisodes, animeStudio, animeGenres);

            // Assert
            mockAnimeRepo.Verify(x => x.UpdateAnime(It.IsAny<Anime>()), Times.Once);
        }

        [Fact]
        public void Check_We_Can_Not_Update_Invalid_Anime()
        {
            // Arrange
            int id = 1;
            string animeName = "";
            string animeDescription = "";
            decimal animeRating = 4.5m;
            int animeReleaseYear = 2022;
            string animeImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/81/Modernanime.jpg";
            Season animeSeason = Season.Autumn;
            int animeNrEpisodes = 12;
            string animeStudio = "Sample Studio";
            List<Genre> animeGenres = new List<Genre>() { Genre.Action, Genre.Comedy };

            // Act & Assert
            Assert.Throws<Exception>(() =>
            {
                animeManager.UpdateAnime(id, animeName, animeDescription, animeRating, animeReleaseYear, animeImageUrl, animeSeason, animeNrEpisodes, animeStudio, animeGenres);
            });
        }
    }
}
