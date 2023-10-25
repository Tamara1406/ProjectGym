using CommunicationClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        Socket socket;
        NetworkStream stream;
        BinaryFormatter formatter;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(this.socket);
            formatter = new BinaryFormatter();
        }

        public void HandleClient()
        {
            try
            {
                while (true)
                {
                    Package request = (Package)formatter.Deserialize(stream);

                    Package response = new Package();

                    switch (request.Operation)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}