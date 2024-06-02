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
    public class AppointmentTest
    {

        private ClientController clientController;

        private ClientCommunication fakeCommunication = A.Fake<ClientCommunication>();

        public AppointmentTest()
        {
            clientController = new ClientController();
            clientController.Communication = fakeCommunication;
        }

        [Fact]
        public void CreateAppointment_SendsRequest_WithCorrectOperation()
        {
            // Arrange
            var newAppointment = new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() };

            // Act
            clientController.CreateAppointment(newAppointment);

            // Assert
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p =>
                p.Item == newAppointment && p.Operation == Operation.AddAppointment))).MustHaveHappened();
        }

        [Fact]
        public void CreateAppointment_ReceivesResponse_AndReturnsTrue_WhenAddClientOk()
        {
            // Arrange
            var newAppointment = new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() };

            var fakeResponse = new Package { Operation = Operation.AddAppointmentOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.CreateAppointment(newAppointment);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.True(result);
        }

        [Fact]
        public void CreateAppointment_ReceivesResponse_AndReturnsFalse_WhenAddAppointmentFails()
        {
            // Arrange
            var newAppointment = new Appointment { Time = DateTime.Today, NumberOfAppointments = 0, Group = null };

            var fakeResponse = new Package { Operation = Operation.AddAppointmentNotOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.CreateAppointment(newAppointment);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.False(result);
        }

        [Fact]
        public void GetAllAppointments_ReturnsListOfAppointments_WhenResponseIsSuccessful()
        {
            // Arrange
            var appointmentList = new List<Appointment>
        {
            new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() { GroupID = 1 } },
            new Appointment { Time = DateTime.Today, NumberOfAppointments = 5, Group = new Group() { GroupID = 2 } }
        };

            var response = new Package
            {
                ItemList = appointmentList.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetAllAppointments();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal(6, result[0].NumberOfAppointments);
            Assert.Equal(5, result[1].NumberOfAppointments);
            Assert.Equal(DateTime.Today, result[0].Time);
            Assert.Equal(DateTime.Today, result[1].Time);
            Assert.Equal(1, result[0].Group.GroupID);
            Assert.Equal(2, result[1].Group.GroupID);

            // Verify that SendRequest was called
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetAllAppointments)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAllAppointments_ReturnsEmptyList_WhenResponseHasNoAppointments()
        {
            // Arrange
            var response = new Package
            {
                ItemList = new List<object>()
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetAllAppointments();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);

            // Verify that SendRequest was called
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetAllAppointments)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetAllAppointmentByGroup_ReturnsCorrectAppointments_WhenMatchExists()
        {
            // Arrange
            var group = new Group { GroupID = 1 };
            var allAppointments = new List<Appointment>
            {
                 new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() { GroupID = 1 } },
                 new Appointment { Time = DateTime.Today, NumberOfAppointments = 5, Group = new Group() { GroupID = 2 } },
                 new Appointment { Time = DateTime.Today, NumberOfAppointments = 4, Group = new Group() { GroupID = 1 } }
            };

            var fakeResponse = new Package
            {
                ItemList = allAppointments.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.GetAllAppointmentsByGroup(group);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.NumberOfAppointments == 6);
            Assert.Contains(result, c => c.NumberOfAppointments == 4);
        }

        [Fact]
        public void GetAllAppointmentByGroup_ReturnsEmptyList_WhenNoMatchExists()
        {
            // Arrange
            var group = new Group { GroupID = 3 };
            var allAppointments = new List<Appointment>
            {
                 new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() { GroupID = 1 } },
                 new Appointment { Time = DateTime.Today, NumberOfAppointments = 5, Group = new Group() { GroupID = 2 } },
                 new Appointment { Time = DateTime.Today, NumberOfAppointments = 4, Group = new Group() { GroupID = 1 } }
            };

            var fakeResponse = new Package
            {
                ItemList = allAppointments.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.GetAllAppointmentsByGroup(group);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void DeleteAppointment_SendsRequest_WithCorrectOperation()
        {
            // Arrange
            var appointmentToDelete = new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() { GroupID = 1 } };

            // Act
            clientController.DeleteAppointment(appointmentToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p =>
                p.Item == appointmentToDelete && p.Operation == Operation.DeleteAppointment))).MustHaveHappened();
        }

        [Fact]
        public void DeleteAppointment_ReceivesResponse_AndReturnsDeletedAppointment()
        {
            // Arrange
            var appointmentToDelete = new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() { GroupID = 1 } };

            var fakeResponse = new Package { Item = appointmentToDelete };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.DeleteAppointment(appointmentToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.NotNull(result);
            Assert.Equal(appointmentToDelete.NumberOfAppointments, result.NumberOfAppointments);
        }

        [Fact]
        public void DeleteAppointment_ReturnsNull_WhenResponseItemIsNull()
        {
            // Arrange
            var appointmentToDelete = new Appointment { Time = DateTime.Today, NumberOfAppointments = 6, Group = new Group() { GroupID = 1 } };

            var fakeResponse = new Package { Item = null };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.DeleteAppointment(appointmentToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.Null(result);
        }


    }
}
