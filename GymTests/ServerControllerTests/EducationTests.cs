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
    public class EducationTests
    {
        private ServerController serverController;

        private BaseSO so = A.Fake<BaseSO>();
        public EducationTests()
        {
            serverController = new ServerController();
        }

        [Fact]
        public void GetAllEducations_ReturnSuccess()
        {
            // Arrange
            var educations = new List<Education>
            {
                new Education { Qualifications = "Osnovne studije"},
                new Education { Qualifications = "Master studije"}
            };
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = educations.Cast<AbsEntity>().ToList();
            });


            // Act
            var result = serverController.GetAllEducations(so);

            // Assert
            Assert.Equal(educations.Count, result.Count);
            foreach (var educ in educations)
            {
                Assert.True(result.Any(c => c.Qualifications == educ.Qualifications));
            }
        }

        [Fact]
        public void GetAllEducations_Returns_Null_When_Not_Found()
        {
            // Arrange
            A.CallTo(() => so.ExecuteOperation()).Invokes(() =>
            {
                so.ResultList = new List<AbsEntity>();
            });


            // Act
            var result = serverController.GetAllEducations(so);

            // Assert
            Assert.Empty(result);
        }

    }
}
