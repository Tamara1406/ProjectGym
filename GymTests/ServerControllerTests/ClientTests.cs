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
    public class ClientTests
    {
        private ServerController serverController;

        private BaseSO so = A.Fake<BaseSO>();
        public ClientTests()
        {
            serverController = new ServerController();
        }

        [Fact]
        public void GetAllClients_ReturnSuccess()
        {
            // Arrange
            var clients = new List<Client>
            {
                new Client { FirstName = "Pera", LastName = "Peric", Gender = Gender.Muski, Height = 185, Weight = 85, Group = new Group() },
                new Client { FirstName = "Mila", LastName = "Milic", Gender = Gender.Zenski, Height = 175, Weight = 65, Group = new Group() }
            };
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = clients.Cast<AbsEntity>().ToList();
            });


            // Act
            var result = serverController.GetAllClients(so);

            // Assert
            Assert.Equal(clients.Count, result.Count);
            foreach (var client in clients)
            {
                Assert.True(result.Any(c => c.FirstName == client.FirstName && c.LastName == client.LastName && c.Gender == client.Gender && c.Height == client.Height && c.Weight == client.Weight && c.Group == client.Group) );
            }
        }

        [Fact]
        public void GetAllClients_Returns_Null_When_Not_Found()
        {
            // Arrange
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = new List<AbsEntity>();
            });


            // Act
            var result = serverController.GetAllClients(so);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void DeleteClient_Success()
        {
            // Arrange
            var fakeClientToDelete = new Client { FirstName = "Pera", LastName = "Peric", Gender = Gender.Muski, Height = 185, Weight = 85, Group = new Group() };
            A.CallTo(() => so.Result).Returns(fakeClientToDelete);

            // Act
            var deletedClient = serverController.DeleteClient(fakeClientToDelete, so);

            // Assert
            Assert.NotNull(deletedClient);
            Assert.Equal(fakeClientToDelete.FirstName, deletedClient.FirstName);
            Assert.Equal(fakeClientToDelete.LastName, deletedClient.LastName);
        }

        [Fact]
        public void DeleteClient_ThrowsException_WhenCoachNotFound()
        {
            // Arrange
            A.CallTo(() => so.Result).Returns(null);

            var fakeClientToDelete = new Client { FirstName = "Pera", LastName = "Peric", Gender = Gender.Muski, Height = 185, Weight = 85, Group = new Group() };

            // Act & Assert
            Assert.Throws<Exception>(() => serverController.DeleteClient(fakeClientToDelete, so));
        }

        [Fact]
        public void UpdateClient_ReturnSuccess()
        {
            // Arrange
            var newData = new Client { FirstName = "Pera", LastName = "Peric", Gender = Gender.Muski, Height = 185, Weight = 85, Group = new Group() };

            // Act
            var result = serverController.UpdateClient(newData, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void UpdateClient_With_InvalidData()
        {
            // Arrange
            var invalidClient = new Client { FirstName = null, LastName = "", Gender = Gender.Muski, Height = 0, Weight = 0, Group = null };

            // Act
            var result = serverController.UpdateClient(invalidClient, so);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CreateClient_ReturnSuccess()
        {
            // Arrange
            var newClient = new Client { FirstName = "Pera", LastName = "Peric", Gender = Gender.Muski, Height = 185, Weight = 85, Group = new Group() };

            // Act
            var result = serverController.CreateClient(newClient, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CreateClient_With_InvalidData()
        {
            // Arrange
            var invalidClient = new Client { FirstName = null, LastName = "", Gender = Gender.Muski, Height = 0, Weight = 0, Group = null };

            // Act
            var result = serverController.CreateClient(invalidClient, so);

            // Assert
            Assert.False(result);
        }

    }
}
