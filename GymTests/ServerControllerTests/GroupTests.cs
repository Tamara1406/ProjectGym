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
    public class GroupTests
    {
        private ServerController serverController;

        private BaseSO so = A.Fake<BaseSO>();
        public GroupTests()
        {
            serverController = new ServerController();
        }

        [Fact]
        public void GetAllGroups_ReturnSuccess()
        {
            // Arrange
            var groups = new List<Group>
            {
                new Group { GroupName = "Pera"}
            };
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = groups.Cast<AbsEntity>().ToList();
            });


            // Act
            var result = serverController.GetAllGroups(so);

            // Assert
            Assert.Equal(groups.Count, result.Count);
            foreach (var group in groups)
            {
                Assert.True(result.Any(c => c.GroupName == group.GroupName));
            }
        }

        [Fact]
        public void GetAllGroups_Returns_Null_When_Not_Found()
        {
            // Arrange
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = new List<AbsEntity>();
            });


            // Act
            var result = serverController.GetAllGroups(so);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void CreateGroup_ReturnSuccess()
        {
            // Arrange
            var newGroup = new Group { GroupName = "Grupa1", Coach = new Coach() };

            // Act
            var result = serverController.CreateGroup(newGroup, so);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CreateGroup_With_InvalidData()
        {
            // Arrange
            var invalidGroup = new Group { GroupName = "", Coach = null };

            // Act
            var result = serverController.CreateGroup(invalidGroup, so);

            // Assert
            Assert.False(result);
        }

    }
}
