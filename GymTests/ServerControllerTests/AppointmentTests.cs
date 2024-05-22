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
    public class AppointmentTests
    {
        private ServerController serverController;

        private BaseSO so = A.Fake<BaseSO>();
        public AppointmentTests()
        {
            serverController = new ServerController();
        }

        [Fact]
        public void CreateAppointment_ReturnSuccess()
        {
            // Arrange
            var newAppointment = new Appointment { Time = new DateTime(2024, 04, 15), NumberOfAppointments = 3, Group =  new Group() };

            // Act
            var result = serverController.CreateAppointment(newAppointment, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CreateAppointment_With_InvalidData()
        {
            // Arrange
            var invalidAppointment = new Appointment { NumberOfAppointments = 0, Group = null};

            // Act
            var result = serverController.CreateAppointment(invalidAppointment, so);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void GetAllAppointments_ReturnSuccess()
        {
            // Arrange
            var appointments = new List<Appointment>
            {
                new Appointment { Time = new DateTime(2024, 04, 15), NumberOfAppointments = 3, Group =  new Group() },
                new Appointment { Time = new DateTime(2024, 04, 16), NumberOfAppointments = 4, Group =  new Group() }
            };
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = appointments.Cast<AbsEntity>().ToList();
            });


            // Act
            var result = serverController.GetAllAppointments(so);

            // Assert
            Assert.Equal(appointments.Count, result.Count);
            foreach (var appointment in appointments)
            {
                Assert.True(result.Any(c => c.Time == appointment.Time && c.NumberOfAppointments == appointment.NumberOfAppointments && c.Group == appointment.Group ));
            }
        }

        [Fact]
        public void GetAllAppointments_Returns_Null_When_Not_Found()
        {
            // Arrange
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = new List<AbsEntity>();
            });


            // Act
            var result = serverController.GetAllAppointments(so);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void DeleteAppointment_Success()
        {
            // Arrange
            var fakeAppointmentToDelete = new Appointment { Time = new DateTime(2024, 04, 15), NumberOfAppointments = 3, Group = new Group() };
            A.CallTo(() => so.Result).Returns(fakeAppointmentToDelete);

            // Act
            var deletedAppointment = serverController.DeleteAppointment(fakeAppointmentToDelete, so);

            // Assert
            Assert.NotNull(deletedAppointment);
            Assert.Equal(fakeAppointmentToDelete.Time, deletedAppointment.Time);
            Assert.Equal(fakeAppointmentToDelete.NumberOfAppointments, deletedAppointment.NumberOfAppointments);
        }

        [Fact]
        public void DeleteAppointment_ThrowsException_WhenCoachNotFound()
        {
            // Arrange
            A.CallTo(() => so.Result).Returns(null);

            var fakeAppointmentToDelete = new Appointment { Time = new DateTime(2024, 04, 15), NumberOfAppointments = 3, Group = new Group() };

            // Act & Assert
            Assert.Throws<Exception>(() => serverController.DeleteAppointment(fakeAppointmentToDelete, so));
        }


        [Fact]
        public void UpdateAppointment_ReturnSuccess()
        {
            // Arrange
            var newData = new Appointment { Time = new DateTime(2024, 04, 15), NumberOfAppointments = 3, Group = new Group() };

            // Act
            var result = serverController.UpdateAppointment(newData, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void UpdateAppointment_With_InvalidData()
        {
            // Arrange
            var invalidAppointment = new Appointment { NumberOfAppointments = 0, Group = null };

            // Act
            var result = serverController.UpdateAppointment(invalidAppointment, so);

            // Assert
            Assert.False(result);
        }

    }
}
