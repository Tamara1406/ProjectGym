using Client;
using CommunicationClasses;
using Domain;
using FakeItEasy;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace GymTests.ClientControllerTests
{
    public class UserTest
    {
        private ClientController clientController;

        private ClientCommunication fakeCommunication = A.Fake<ClientCommunication>();

        public UserTest()
        {
            clientController = new ClientController();
            clientController.Communication = fakeCommunication;
        }

        [Fact]
        public void LoginClient_Returns_1_When_Login_Successful()
        {
            // Arrange
            var user = new User { Username = "testUser", Password = "testPass" };

            var loginOkResponse = new Package
            {
                Operation = Operation.LoginOk
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(loginOkResponse);

            // Act
            var result = clientController.LoginClient(user);

            // Assert
            Assert.Equal(1, result);
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.LoginClient && p.Item == user)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void LoginClient_Returns_2_When_Already_Logged()
        {
            // Arrange
            var user = new User { Username = "testUser", Password = "testPass" };

            var alreadyLoggedResponse = new Package
            {
                Operation = Operation.AlreadyLogged
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(alreadyLoggedResponse);

            // Act
            var result = clientController.LoginClient(user);

            // Assert
            Assert.Equal(2, result);
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.LoginClient && p.Item == user)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void LoginClient_Returns_3_When_Login_Fails()
        {
            // Arrange
            var user = new User { Username = "testUser", Password = "testPass" };

            var loginFailedResponse = new Package
            {
                Operation = Operation.LoginNotOk
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(loginFailedResponse);

            // Act
            var result = clientController.LoginClient(user);

            // Assert
            Assert.Equal(3, result);
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.LoginClient && p.Item == user)))
                .MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetUserByUsername_ReturnsUser_WhenUserIsFound()
        {
            // Arrange
            var userToFind = new User { Username = "testUser" };
            var expectedUser = new User { Username = "testUser", Password = "password123" };

            var response = new Package
            {
                Operation = Operation.GetUserByUsername,
                Item = expectedUser
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetUserByUsername(userToFind);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedUser.Username, result.Username);
            Assert.Equal(expectedUser.Password, result.Password);

            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetUserByUsername && p.Item == userToFind))).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetUserByUsername_ReturnsNull_WhenUserIsNotFound()
        {
            // Arrange
            var userToFind = new User { Username = "testUser" };

            var response = new Package
            {
                Operation = Operation.GetUserByUsername,
                Item = null
            };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.GetUserByUsername(userToFind);

            // Assert
            Assert.Null(result);

            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.GetUserByUsername && p.Item == userToFind))).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void CreateAccount_ReturnsTrue_WhenRegisterOk()
        {
            // Arrange
            var user = new User { Username = "testUser", Password = "testPass" };

            var response = new Package { Operation = Operation.RegisterOk };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.CreateAccount(user);

            // Assert
            Assert.True(result);
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.RegisterUser && p.Item == user))).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void CreateAccount_ReturnsFalse_WhenRegisterNotOk()
        {
            // Arrange
            var user = new User { Username = "testUser", Password = "testPass" };


            var response = new Package { Operation = Operation.RegisterNotOk };

            A.CallTo(() => fakeCommunication.RecieveResponse()).Returns(response);

            // Act
            var result = clientController.CreateAccount(user);

            // Assert
            Assert.False(result);
            A.CallTo(() => fakeCommunication.SendRequest(A<Package>.That.Matches(p => p.Operation == Operation.RegisterUser && p.Item == user))).MustHaveHappenedOnceExactly();
        }

        

    }
}
