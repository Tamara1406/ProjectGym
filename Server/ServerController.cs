using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace Server
{
    public class ServerController
    {
        private static ServerController instance;
        public static ServerController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServerController();
                }
                return instance;
            }
        }
        private ServerController()
        {
        }

        BaseSO operation;

    }
}
