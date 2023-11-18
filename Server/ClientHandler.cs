using CommunicationClasses;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
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
                        case Operation.LoginClient:


                            User user = (User)request.Item;

                            if (!ValidatorServer.CheckUser(user))
                            {
                                response.Operation = Operation.AlreadyLogged;
                                formatter.Serialize(stream, response);
                            }
                            else if (ServerController.Instance.LoginCheck(user))
                            {
                                response.Operation = Operation.LoginOk;
                                formatter.Serialize(stream, response);
                            }
                            else
                                formatter.Serialize(stream, response);

                            break;

                        case Operation.RegisterUser:

                            User newUser = (User)request.Item;

                            ServerController.Instance.RegisterUSer(newUser);
                            response.Operation = Operation.RegisterOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetUserByUsername:

                            User userToFind = (User)request.Item;

                            User userFound = ServerController.Instance.GetUserByUsername(userToFind);

                            response.Item = userFound;

                            formatter.Serialize(stream, response);
                            break;

                        case Operation.UpdateUser:

                            User userToUpdate = (User)request.Item;

                            if (!ValidatorServer.CheckUniqueData(userToUpdate))
                            {
                                response.Operation = Operation.UserUpdateNotOk;

                                formatter.Serialize(stream, response);

                            }
                            else
                            {
                                ServerController.Instance.UpdateUser(userToUpdate);

                                response.Operation = Operation.UserUpdateOk;

                                formatter.Serialize(stream, response);
                            }

                            break;

                        case Operation.GetAllCoaches:

                            List<Coach> coaches = ServerController.Instance.GetAllCoaches();

                            response.ItemList = coaches.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllEducations:

                            List<Education> educations = ServerController.Instance.GetAllEducations();

                            response.ItemList = educations.ConvertAll(x => (object)x);
                            formatter.Serialize(stream, response);

                            break;

                        case Operation.DeleteCoach:

                            Coach resToDelete = (Coach)request.Item;

                            ServerController.Instance.DeleteCoach(resToDelete);

                            response.Operation = Operation.UpdateCoachOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllGroups:

                            List<Group> groups = ServerController.Instance.GetAllGroups();

                            response.ItemList = groups.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.UpdateCoach:

                            Coach resToUpdate = (Coach)request.Item;

                            ServerController.Instance.UpdateCoach(resToUpdate);

                            response.Operation = Operation.UpdateCoachOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddCoach:

                            Coach coach = (Coach)request.Item;

                            ServerController.Instance.CreateCoach(coach);
                            response.Operation = Operation.AddCoachOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllClients:

                            List<Client> clients = ServerController.Instance.GetAllClients();

                            response.ItemList = clients.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.DeleteClient:

                            Client clientToDelete = (Client)request.Item;

                            ServerController.Instance.DeleteClient(clientToDelete);

                            response.Operation = Operation.UpdateClientOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.UpdateClient:

                            Client clientToUpdate = (Client)request.Item;

                            ServerController.Instance.UpdateClient(clientToUpdate);

                            response.Operation = Operation.UpdateClientOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddClient:

                            Client client = (Client)request.Item;

                            ServerController.Instance.CreateClient(client);
                            response.Operation = Operation.AddClientOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddAppointment:

                            Appointment appointment = (Appointment)request.ItemList[0];
                            Group group = (Group)request.ItemList[1];

                            ServerController.Instance.CreateAppointment(appointment, group);
                            response.Operation = Operation.AddAppointmentOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllAppointments:

                            List<Appointment> appointments = ServerController.Instance.GetAllAppointments();

                            response.ItemList = appointments.ConvertAll(x => (object)x);
                            formatter.Serialize(stream, response);

                            break;

                        case Operation.DeleteAppointment:

                            Appointment appToDelete = (Appointment)request.Item;

                            ServerController.Instance.DeleteAppointment(appToDelete);

                            response.Operation = Operation.UpdateAppointmentOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.UpdateAppointment:

                            Appointment appToUpdate = (Appointment)request.ItemList[0];
                            Group groupToUpdate = (Group)request.ItemList[1];

                            ServerController.Instance.UpdateAppointment(appToUpdate, groupToUpdate);

                            response.Operation = Operation.UpdateAppointmentOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllAttendances:

                            List<Attendance> attendances = ServerController.Instance.GetAllAttendances();

                            response.ItemList = attendances.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddAttendance:

                            Attendance attendance = (Attendance)request.Item;

                            ServerController.Instance.CreateAttendance(attendance);
                            response.Operation = Operation.AddAttendanceOk;

                            formatter.Serialize(stream, response);

                            break;
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