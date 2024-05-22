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
    }
}
