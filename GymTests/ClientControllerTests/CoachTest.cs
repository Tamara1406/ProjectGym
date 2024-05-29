using Client;
using CommunicationClasses;
using Domain;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTests.ClientControllerTests
{
    public class CoachTest
    {
        private ClientController clientController;

        private ClientCommunication fakeCommunication = A.Fake<ClientCommunication>();

        public CoachTest()
        {
            clientController = new ClientController();
            clientController.Communication = fakeCommunication;
        }

        [Fact]
        public void GetAllCoaches_ReturnsListOfCoaches_WhenResponseIsSuccessful()
        {
            // Arrange
            var coachList = new List<Coach>
        {
            new Coach { FirstName = "Pera", LastName = "Peric" },
            new Coach { FirstName = "Mika", LastName = "Mikic" }
        };

            var response = new Package
            {
                ItemList = coachList.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetAllCoaches();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Pera", result[0].FirstName);
            Assert.Equal("Mika", result[1].FirstName);

            // Verify that SendRequest was called
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetAllCoaches)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAllCoaches_ReturnsEmptyList_WhenResponseHasNoCoaches()
        {
            // Arrange
            var response = new Package
            {
                ItemList = new List<object>() 
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetAllCoaches();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);

            // Verify that SendRequest was called
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetAllCoaches)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetCoachSearchedByName_ReturnsCorrectCoaches_WhenMatchExists()
        {
            // Arrange
            var fakeClientController = A.Fake<ClientController>();
            var allCoaches = new List<Coach>
        {
            new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education() },
            new Coach { FirstName = "Mika", LastName = "Mikic", Education = new Education() },
            new Coach { FirstName = "Perica", LastName = "Zikic", Education = new Education() }
        };

            A.CallTo(() => fakeClientController.GetAllCoaches()).Returns(allCoaches);

            // Act
            var result = fakeClientController.GetCoachSearchedByName("per");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.FirstName == "Pera" && c.LastName =="Peric");
            Assert.Contains(result, c => c.FirstName == "Perica" && c.LastName == "Zikic");
        }

        [Fact]
        public void GetCoachSearchedByName_ReturnsEmptyList_WhenNoMatchExists()
        {
            // Arrange
            var fakeClientController = A.Fake<ClientController>();

            var allCoaches = new List<Coach>
        {
            new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education() },
            new Coach { FirstName = "Mika", LastName = "Mikic", Education = new Education() },
            new Coach { FirstName = "Perica", LastName = "Zikic", Education = new Education() }
        };

            A.CallTo(() => fakeClientController.GetAllCoaches()).Returns(allCoaches);

            // Act
            var result = fakeClientController.GetCoachSearchedByName("zika");

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void GetCoachSearchedByName_ReturnsAllCoaches_WhenSearchStrIsEmpty()
        {
            // Arrange
            var fakeClientController = A.Fake<ClientController>();

            var allCoaches = new List<Coach>
        {
            new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education() },
            new Coach { FirstName = "Mika", LastName = "Mikic", Education = new Education() },
            new Coach { FirstName = "Perica", LastName = "Zikic", Education = new Education() }
        };

            A.CallTo(() => fakeClientController.GetAllCoaches()).Returns(allCoaches);

            // Act
            var result = fakeClientController.GetCoachSearchedByName("");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void GetAllCoachByEducation_ReturnsCorrectCoaches_WhenMatchExists()
        {
            // Arrange
            var education = new Education { EducationID = 1 };
            var allCoaches = new List<Coach>
            {
                new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } },
                new Coach { FirstName = "Mika", LastName = "Mikic", Education = new Education { EducationID = 2 } },
                new Coach { FirstName = "Perica", LastName = "Zikic", Education = new Education { EducationID = 1 } }
            };

            var fakeResponse = new Package
            {
                ItemList = allCoaches.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.GetAllCoachByEducation(education);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.FirstName == "Pera" && c.LastName == "Peric");
            Assert.Contains(result, c => c.FirstName == "Perica" && c.LastName == "Zikic");
        }

        [Fact]
        public void GetAllCoachByEducation_ReturnsEmptyList_WhenNoMatchExists()
        {
            // Arrange
            var education = new Education { EducationID = 3 };
            var allCoaches = new List<Coach>
            {
                new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } },
                new Coach { FirstName = "Mika", LastName = "Mikic", Education = new Education { EducationID = 2 } },
                new Coach { FirstName = "Perica", LastName = "Zikic", Education = new Education { EducationID = 1 } }
            };

            var fakeResponse = new Package
            {
                ItemList = allCoaches.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.GetAllCoachByEducation(education);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void DeleteCoach_SendsRequest_WithCorrectOperation()
        {
            // Arrange
            var coachToDelete = new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } };

            // Act
            clientController.DeleteCoach(coachToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p =>
                p.Item == coachToDelete && p.Operation == Operation.DeleteCoach))).MustHaveHappened();
        }

        [Fact]
        public void DeleteCoach_ReceivesResponse_AndReturnsDeletedCoach()
        {
            // Arrange
            var coachToDelete = new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } };

            var fakeResponse = new Package { Item = coachToDelete };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.DeleteCoach(coachToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.NotNull(result);
            Assert.Equal(coachToDelete.Name, result.Name);
        }

        [Fact]
        public void DeleteCoach_ReturnsNull_WhenResponseItemIsNull()
        {
            // Arrange
            var coachToDelete = new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } };

            var fakeResponse = new Package { Item = null };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.DeleteCoach(coachToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.Null(result);
        }

        [Fact]
        public void UpdateCoach_SendsRequest_WithCorrectOperation()
        {
            // Arrange
            var coachToUpdate = new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } };

            // Act
            clientController.UpdateCoach(coachToUpdate);

            // Assert
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p =>
                p.Item == coachToUpdate && p.Operation == Operation.UpdateCoach))).MustHaveHappened();
        }

        [Fact]
        public void UpdateCoach_ReceivesResponse_AndReturnsTrue_WhenUpdateSuccessful()
        {
            // Arrange
            var coachToUpdate = new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } };

            var fakeResponse = new Package { Operation = Operation.UpdateCoachOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.UpdateCoach(coachToUpdate);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.True(result);
        }

        [Fact]
        public void UpdateCoach_ReceivesResponse_AndReturnsFalse_WhenUpdateFails()
        {
            // Arrange
            var coachToUpdate = new Coach { FirstName = "", LastName = "Peric", Education = null };

            var fakeResponse = new Package { Operation = Operation.UpdateCoachNotOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.UpdateCoach(coachToUpdate);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.False(result);
        }

        [Fact]
        public void CreateCoach_SendsRequest_WithCorrectOperation()
        {
            // Arrange
            var newCoach = new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } };

            // Act
            clientController.CreateCoach(newCoach);

            // Assert
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p =>
                p.Item == newCoach && p.Operation == Operation.AddCoach))).MustHaveHappened();
        }

        [Fact]
        public void CreateCoach_ReceivesResponse_AndReturnsTrue_WhenAddCoachOk()
        {
            // Arrange
            var newCoach = new Coach { FirstName = "Pera", LastName = "Peric", Education = new Education { EducationID = 1 } };

            var fakeResponse = new Package { Operation = Operation.AddCoachOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.CreateCoach(newCoach);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.True(result);
        }

        [Fact]
        public void CreateCoach_ReceivesResponse_AndReturnsFalse_WhenAddCoachFails()
        {
            // Arrange
            var newCoach = new Coach { FirstName = "", LastName = "Peric", Education = null };

            var fakeResponse = new Package { Operation = Operation.AddCoachNotOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.CreateCoach(newCoach);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.False(result);
        }




    }

}

