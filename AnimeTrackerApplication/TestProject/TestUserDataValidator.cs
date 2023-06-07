using Logic.Mangas;
using Logic.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestUserDataValidator
    {
        private readonly UserDataValidator udv;

        public TestUserDataValidator()
        {
            udv = new UserDataValidator();
        }

        [Fact]
        public void IsNameValid_ShouldReturnTrue_WhenValidNameIsProvided()
        {
            // Arrange
            string name = "John Doe";

            // Act
            bool result = udv.IsNameValid(name);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNameValid_ShouldThrowException_WhenInvalidNameIsProvided()
        {
            // Arrange
            string name = "John_123";

            // Act & Assert
            Assert.Throws<Exception>(() => udv.IsNameValid(name));
        }

        [Fact]
        public void IsEmailValid_ShouldReturnTrue_WhenValidEmailIsProvided()
        {
            // Arrange
            string email = "example@example.com";

            // Act
            bool result = udv.IsEmailValid(email);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmailValid_ShouldThrowException_WhenInvalidEmailIsProvided()
        {
            // Arrange
            string email = "invalid_email";

            // Act & Assert
            Assert.Throws<Exception>(() => udv.IsEmailValid(email));
        }

        [Fact]
        public void IsPasswordValid_ShouldReturnTrue_WhenValidPasswordIsProvided()
        {
            // Arrange
            string password = "password123";

            // Act
            bool result = udv.IsPasswordValid(password);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPasswordValid_ShouldThrowException_WhenPasswordWithoutDigitIsProvided()
        {
            // Arrange
            string password = "password";

            // Act & Assert
            Assert.Throws<Exception>(() => udv.IsPasswordValid(password));
        }
    }
}
