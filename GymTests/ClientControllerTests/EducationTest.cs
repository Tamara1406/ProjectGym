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
    public class EducationTest
    {
        private ClientController clientController;

        private ClientCommunication fakeCommunication = A.Fake<ClientCommunication>();

        public EducationTest()
        {
            clientController = new ClientController();
            clientController.Communication = fakeCommunication;
        }

        [Fact]
        public void GetAllEducations_ReturnsListOfEducations_WhenResponseIsSuccessful()
        {
            // Arrange
            var educationList = new List<Education>
        {
            new Education { Qualifications = "osnovne studije" },
            new Education { Qualifications = "master studije" }
        };

            var response = new Package
            {
                ItemList = educationList.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetAllEducations();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("osnovne studije", result[0].Qualifications);
            Assert.Equal("master studije", result[1].Qualifications);

            // Verify that SendRequest was called
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetAllEducations)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAllEducations_ReturnsEmptyList_WhenResponseHasNoEducations()
        {
            // Arrange
            var response = new Package
            {
                ItemList = new List<object>()
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetAllEducations();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);

            // Verify that SendRequest was called
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetAllEducations)))
                .MustHaveHappenedOnceExactly();
        }


    }
}
