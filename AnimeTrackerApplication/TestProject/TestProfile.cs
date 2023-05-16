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

        public TestProfile()
        {
            profile = new Profile();
        }

        [Fact]
        public void Are_Remaining_Minutes_Calculated_Correctly()
        {
            // Arrange
            int totalMinutes = 78;
            // Act
            int result = profile.CalculateAnimeMinutes(totalMinutes);
            // Assert
            Assert.Equal(18, result);
        }

        [Fact]
        public void Are_Remaining_Hours_Calculated_Correctly()
        {
            // Arrange
            int totalMinutes = 450;
            // Act
            int result = profile.CalculateAnimeHours(totalMinutes);
            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Are_Remaining_Days_Calculated_Correctly()
        {
            // Arrange
            int totalMinutes = 4444;
            // Act
            int result = profile.CalculateAnimeDays(totalMinutes);
            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Are_Remaining_Months_Calculated_Correctly()
        {
            // Arrange
            int totalMinutes = 172999;
            // Act
            int result = profile.CalculateAnimeMonths(totalMinutes);
            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Are_Years_Calculated_Correctly()
        {
            // Arrange
            int totalMinutes = 2000002;
            // Act
            int result = profile.CalculateAnimeYears(totalMinutes);
            // Assert
            Assert.Equal(3, result);
        }
    }
}
