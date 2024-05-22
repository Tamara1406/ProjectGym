using CommunicationClasses;
using Domain;
using FakeItEasy;
using Server;
using System.Runtime.Serialization;
using SystemOperations;
using SystemOperations.UserSO;

namespace GymTests.ServerControllerTests
{
    public class UserTests
    {

        private ServerController serverController;

        private BaseSO so = A.Fake<BaseSO>();
        public UserTests()
        {
            serverController = new ServerController();
        }

        [Fact]
        public void Login_ReturnSuccess()
        {

            A.CallTo(() => so.ExecuteOperation());
            A.CallTo(() => so.ResultList).Returns(new List<AbsEntity>
            {
                new User { Username = "ime", Password = "ime123" }
            });

            // Act
            var result = serverController.Login(new User { Username = "ime", Password = "ime123" }, so);

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void Login_ReturnError()
        {

            A.CallTo(() => so.ExecuteOperation());
            A.CallTo(() => so.ResultList).Returns(new List<AbsEntity>
            {
                new User { Username = "ime", Password = "ime123" }
            });

            // Act
            var result = serverController.Login(new User { Username = "ime", Password = "ime333" }, so);

            // Assert
            Assert.False(result);

        }

        [Fact]
        public void RegisterUser_ReturnSuccess()
        {
            // Arrange
            var newUser = new User { Username = "ime", Password = "ime123", FirstName = "ime", LastName = "prezime", Email = "ime@gmail.com" };

            // Act
            var result = serverController.RegisterUser(newUser, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void RegisterUser_With_InvalidData()
        {
            // Arrange
            var invalidUser = new User { Username = "", Password = "", FirstName = "", LastName = "", Email = "" };

            // Act
            var result = serverController.RegisterUser(invalidUser, so);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetUserByUsername_ReturnSuccess()
        {
            // Arrange
            var user = new User { Username = "existingUsername" };
            var expectedResult = new User { Username = "existingUsername", Password = "ime123", FirstName = "ime", LastName = "prezime", Email = "ime@gmail.com" };

            A.CallTo(() => so.ExecuteOperation());
            A.CallTo(() => so.Result).Returns(expectedResult);


            // Act
            var result = serverController.GetUserByUsername(user, so);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetUserByUsername_Returns_Null_When_Not_Found()
        {
            // Arrange
            var user = new User { Username = "nonExistingUsername" };

            A.CallTo(() => so.ExecuteOperation());
            A.CallTo(() => so.Result).Returns((User)null); 

            var serverController = new ServerController();

            // Act
            var result = serverController.GetUserByUsername(user, so);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void UpdateUser_ReturnSuccess()
        {
            // Arrange
            var newData = new User { Username = "ime", Password = "ime123", FirstName = "ime", LastName = "prezime", Email = "ime@gmail.com" };

            // Act
            var result = serverController.UpdateUser(newData, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void UpdateUser_With_InvalidData()
        {
            // Arrange
            var invalidUser = new User { Username = "", Password = "", FirstName = "", LastName = "", Email = "" };

            // Act
            var result = serverController.UpdateUser(invalidUser, so);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetAllUsers_ReturnSuccess()
        {
            // Arrange
            var users = new List<User>
            {
                new User { Username = "user1" },
                new User { Username = "user2" }
            };
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = users.Cast<AbsEntity>().ToList();
            });


            // Act
            var result = serverController.GetAllUsers(so);

            // Assert
            Assert.Equal(users.Count, result.Count);
            foreach (var user in users)
            {
                Assert.True(result.Any(u => u.Username == user.Username));
            }
        }

        [Fact]
        public void GetAllUsers_Returns_Null_When_Not_Found()
        {
            // Arrange
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = new List<AbsEntity>();
            });


            // Act
            var result = serverController.GetAllUsers(so);

            // Assert
            Assert.Empty(result);
        }

        
        

    }
}
