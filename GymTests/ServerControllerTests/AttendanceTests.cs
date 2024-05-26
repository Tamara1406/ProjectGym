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
    public class AttendanceTests
    {
        private ServerController serverController;

        private BaseSO so = A.Fake<BaseSO>();
        public AttendanceTests()
        {
            serverController = new ServerController();
        }

        [Fact]
        public void GetAllAttendances_ReturnSuccess()
        {
            // Arrange
            var attendances = new List<Attendance>
            {
                new Attendance { Client = new Client(), Appointment = new Appointment(), IsAttend = true },
                new Attendance { Client = new Client(), Appointment = new Appointment(), IsAttend = true }
            };
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = attendances.Cast<AbsEntity>().ToList();
            });


            // Act
            var result = serverController.GetAllAttendances(so);

            // Assert
            Assert.Equal(attendances.Count, result.Count);
            foreach (var attendance in attendances)
            {
                Assert.True(result.Any(c => c.Client == attendance.Client && c.Appointment == attendance.Appointment && c.IsAttend == attendance.IsAttend));
            }
        }

        [Fact]
        public void GetAllAttendances_Returns_Null_When_Not_Found()
        {
            // Arrange
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = new List<AbsEntity>();
            });


            // Act
            var result = serverController.GetAllAttendances(so);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void CreateAttendances_ReturnSuccess()
        {
            // Arrange
            var newAttendances = new List<Attendance> {new Attendance { Client = new Client(), Appointment = new Appointment(), IsAttend = true },
                                                       new Attendance { Client = new Client(), Appointment = new Appointment(), IsAttend = true } };
            // Act
            var result = serverController.CreateAttendances(newAttendances, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CreateAttendances_With_InvalidData()
        {
            // Arrange
            var invalidAttendance = new List<Attendance> { new Attendance { Client = null, Appointment = null, IsAttend = false },
                                                           new Attendance { Client = null, Appointment = null, IsAttend = false } };

            // Act
            var result = serverController.CreateAttendances(invalidAttendance, so);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void DeleteAttendance_Success()
        {
            // Arrange
            var fakeAttendanceToDelete = new Attendance { Client = new Client(), Appointment = new Appointment(), IsAttend = true };
            A.CallTo(() => so.Result).Returns(fakeAttendanceToDelete);

            // Act
            var deletedAttendance = serverController.DeleteAttendance(fakeAttendanceToDelete, so);

            // Assert
            Assert.NotNull(deletedAttendance);
            Assert.Equal(fakeAttendanceToDelete.Client.ClientID, deletedAttendance.Client.ClientID);
            Assert.Equal(fakeAttendanceToDelete.Appointment.AppointmentID, deletedAttendance.Appointment.AppointmentID);
        }

        [Fact]
        public void DeleteAttendance_ThrowsException_WhenCoachNotFound()
        {
            // Arrange
            A.CallTo(() => so.Result).Returns(null);

            var fakeAttendanceToDelete = new Attendance { Client = new Client(), Appointment = new Appointment(), IsAttend = true };

            // Act & Assert
            Assert.Throws<Exception>(() => serverController.DeleteAttendance(fakeAttendanceToDelete, so));
        }

    }
}
