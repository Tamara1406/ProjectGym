using Domain;
using FakeItEasy;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace GymTests.ServerControllerTests
{
    public class CoachTests
    {
        private ServerController serverController;

        private BaseSO so = A.Fake<BaseSO>();
        public CoachTests()
        {
            serverController = new ServerController();
        }


        [Fact]
        public void GetAllCoaches_ReturnSuccess()
        {
            // Arrange
            var coaches = new List<Coach>
            {
                new Coach { FirstName = "Pera", LastName = "Peric"},
                new Coach { FirstName = "Mika", LastName = "Mikic" }
            };
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = coaches.Cast<AbsEntity>().ToList();
            });


            // Act
            var result = serverController.GetAllCoaches(so);

            // Assert
            Assert.Equal(coaches.Count, result.Count);
            foreach (var coach in coaches)
            {
                Assert.True(result.Any(c => c.FirstName == coach.FirstName && c.LastName == coach.LastName));
            }
        }

        [Fact]
        public void GetAllCoaches_Returns_Null_When_Not_Found()
        {
            // Arrange
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = new List<AbsEntity>();
            });


            // Act
            var result = serverController.GetAllCoaches(so);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void DeleteCoach_Success()
        {
            // Arrange
            var fakeCoachToDelete = new Coach { FirstName = "Pera", LastName = "Peric" };
            A.CallTo(() => so.Result).Returns(fakeCoachToDelete);

            // Act
            var deletedCoach = serverController.DeleteCoach(fakeCoachToDelete, so);

            // Assert
            Assert.NotNull(deletedCoach);
            Assert.Equal(fakeCoachToDelete.FirstName, deletedCoach.FirstName);
            Assert.Equal(fakeCoachToDelete.LastName, deletedCoach.LastName);
        }

        [Fact]
        public void DeleteCoach_ThrowsException_WhenCoachNotFound()
        {
            // Arrange
            A.CallTo(() => so.Result).Returns(null);

            var fakeCoachToDelete = new Coach { FirstName = "Pera", LastName = "Peric" };

            // Act & Assert
            Assert.Throws<Exception>(() => serverController.DeleteCoach(fakeCoachToDelete, so));
        }

        [Fact]
        public void UpdateCoach_ReturnSuccess()
        {
            // Arrange
            var newData = new Coach { FirstName = "ime", LastName = "prezime", Education = new Education() };

            // Act
            var result = serverController.UpdateCoach(newData, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void UpdateCoach_With_InvalidData()
        {
            // Arrange
            var invalidUser = new Coach { FirstName = "", LastName = "", Education = null };

            // Act
            var result = serverController.UpdateCoach(invalidUser, so);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CreateCoach_ReturnSuccess()
        {
            // Arrange
            var newCoach = new Coach { FirstName = "ime", LastName = "prezime", Education = new Education() };

            // Act
            var result = serverController.CreateCoach(newCoach, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CreateCoach_With_InvalidData()
        {
            // Arrange
            var invalidCoach = new Coach { FirstName = "", LastName = "", Education = null };

            // Act
            var result = serverController.CreateCoach(invalidCoach, so);

            // Assert
            Assert.False(result);
        }


    }
}
