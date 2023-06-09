using Logic.Animes;
using Logic.Enums;
using Logic.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestProfile
    {
        private readonly Profile profile;
        private readonly CustomList mockCustomList;

        public TestProfile()
        {
            profile = new Profile();
            mockCustomList = new CustomList(1, "Watched", "Anime");
            for (int i = 1; i <= 30; i++)
            {
                Anime anime = new Anime(i, "Anime" + i, "Description" + i, 5, 2023, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bb/Anime_eye.svg/70px-Anime_eye.svg.png" + i, Season.Spring, i * 29, "Studio" + i, new List<Genre>());
                mockCustomList.AddContent(anime);
            }
            profile.AddCustomList(mockCustomList);
        }

        [Fact]
        public void Are_Total_Minutes_Calculated_Correctly()
        {
            // Act
            int result = profile.CalculateTotalMinutesAnime();
            // Assert
            Assert.Equal(323640, result);
        }

        [Fact]
        public void Are_Remaining_Minutes_Calculated_Correctly()
        {
            // Act
            int result = profile.CalculateAnimeMinutes();
            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Are_Remaining_Hours_Calculated_Correctly()
        {
            // Act
            int result = profile.CalculateAnimeHours();
            // Assert
            Assert.Equal(18, result);
        }

        [Fact]
        public void Are_Remaining_Days_Calculated_Correctly()
        {
            // Act
            int result = profile.CalculateAnimeDays();
            // Assert
            Assert.Equal(14, result);
        }

        [Fact]
        public void Are_Remaining_Months_Calculated_Correctly()
        {
            // Act
            int result = profile.CalculateAnimeMonths();
            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Are_Years_Calculated_Correctly()
        {
            // Act
            int result = profile.CalculateAnimeYears();
            // Assert
            Assert.Equal(0, result);
        }
    }
}
