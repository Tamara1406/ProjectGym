using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientController
    {
        public ClientCommunication Communication { get; set; }

        private static ClientController instance;
        public static ClientController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientController();
                }
                return instance;
            }
        }
    }
}
