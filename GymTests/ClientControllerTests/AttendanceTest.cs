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
    public class AttendanceTest
    {

        private ClientController clientController;

        private ClientCommunication fakeCommunication = A.Fake<ClientCommunication>();

        public AttendanceTest()
        {
            clientController = new ClientController();
            clientController.Communication = fakeCommunication;
        }

        [Fact]
        public void CreateAttendances_SendsRequest_WithCorrectOperationAndItems()
        {
            // Arrange
            var attendances = new List<Attendance>
        {
            new Attendance { Client = new Domain.Client(){ClientID=1}, Appointment = new Appointment(){AppointmentID=1}, IsAttend = true },
            new Attendance { Client = new Domain.Client(){ClientID=1}, Appointment = new Appointment(){AppointmentID=1}, IsAttend = true }
        };

            // Act
            clientController.CreateAttendances(attendances);

            // Assert
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p =>
                p.Operation == Operation.AddAttendances &&
                p.ItemList.Count == attendances.Count &&
                p.ItemList[0] == attendances[0] &&
                p.ItemList[1] == attendances[1]))).MustHaveHappened();
        }

        [Fact]
        public void CreateAttendances_ReceivesResponse_AndReturnsTrue_WhenAddAttendancesOk()
        {
            // Arrange
            var attendances = new List<Attendance>
        {
            new Attendance { Client = new Domain.Client(){ClientID=1}, Appointment = new Appointment(){AppointmentID=1}, IsAttend = true },
            new Attendance { Client = new Domain.Client(){ClientID=1}, Appointment = new Appointment(){AppointmentID=1}, IsAttend = true }
        };

            var fakeResponse = new Package { Operation = Operation.AddAttendancesOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.CreateAttendances(attendances);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.True(result);
        }

        [Fact]
        public void CreateAttendances_ReceivesResponse_AndReturnsFalse_WhenAddAttendancesFails()
        {
            // Arrange
            var attendances = new List<Attendance>
            {
                new Attendance { Client = new Domain.Client(){ClientID=1}, Appointment = new Appointment(){AppointmentID=1}, IsAttend = true },
                new Attendance { Client = new Domain.Client(){ClientID=1}, Appointment = new Appointment(){AppointmentID=1}, IsAttend = true }
            };

            var fakeResponse = new Package { Operation = Operation.AddAttendancesNotOk };
            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.CreateAttendances(attendances);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.False(result);
        }

        [Fact]
        public void GetAllAttendances_ReceivesResponse_AndReturnsAttendanceList()
        {
            // Arrange

            var expectedAttendances = new List<Attendance>
        {
            new Attendance { Client = new Domain.Client { ClientID = 1 }, Appointment = new Appointment { AppointmentID = 1 }, IsAttend = true },
            new Attendance { Client = new Domain.Client { ClientID = 2 }, Appointment = new Appointment { AppointmentID = 2 }, IsAttend = false }
        };

            var fakeResponse = new Package
            {
                ItemList = expectedAttendances.ConvertAll(x => (object)x)
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.GetAllAttendances();

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.Equal(expectedAttendances.Count, result.Count);

            for (int i = 0; i < expectedAttendances.Count; i++)
            {
                Assert.Equal(expectedAttendances[i].Client.ClientID, result[i].Client.ClientID);
                Assert.Equal(expectedAttendances[i].Appointment.AppointmentID, result[i].Appointment.AppointmentID);
                Assert.Equal(expectedAttendances[i].IsAttend, result[i].IsAttend);
            }
        }

        [Fact]
        public void DeleteAttendance_SendsRequest_WithCorrectOperation()
        {
            // Arrange

            var attendanceToDelete = new Attendance
            {
                Client = new Domain.Client { ClientID = 1 },
                Appointment = new Appointment { AppointmentID = 1 },
                IsAttend = true
            };

            // Act
            clientController.DeleteAttendance(attendanceToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p =>
                p.Operation == Operation.DeleteAttendance && p.Item == attendanceToDelete))).MustHaveHappened();
        }

        [Fact]
        public void DeleteAttendance_ReceivesResponse_AndReturnsDeletedAttendance()
        {
            // Arrange

            var attendanceToDelete = new Attendance
            {
                Client = new Domain.Client { ClientID = 1 },
                Appointment = new Appointment { AppointmentID = 1 },
                IsAttend = true
            };

            var fakeResponse = new Package
            {
                Item = attendanceToDelete,
                Operation = Operation.DeleteAttendance
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(fakeResponse);

            // Act
            var result = clientController.DeleteAttendance(attendanceToDelete);

            // Assert
            A.CallTo(() => fakeCommunication.RecieveResponse()).MustHaveHappened();
            Assert.NotNull(result);
            Assert.Equal(attendanceToDelete.Client.ClientID, result.Client.ClientID);
            Assert.Equal(attendanceToDelete.Appointment.AppointmentID, result.Appointment.AppointmentID);
            Assert.Equal(attendanceToDelete.IsAttend, result.IsAttend);
        }
    }
}
