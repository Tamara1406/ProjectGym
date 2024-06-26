﻿using CommunicationClasses;
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
using SystemOperations.AppointmentSO;
using SystemOperations.Attendance;
using SystemOperations.ClientSO;
using SystemOperations.CoachSO;
using SystemOperations.EducationSO;
using SystemOperations.GroupSO;
using SystemOperations.UserSO;

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
                            else if(ServerController.Instance.Login(user, new GetAllUsersSO()))
                            {
                                
                                formatter.Serialize(stream, response);
                            }
                            else
                                response.Operation = Operation.LoginNotOk;
                                formatter.Serialize(stream, response);
                            break;

                        case Operation.RegisterUser:

                            User newUser = (User)request.Item;

                            if(ServerController.Instance.RegisterUser(newUser, new CreateAccountSO(newUser)))
                                response.Operation = Operation.RegisterOk;
                            else response.Operation = Operation.RegisterNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetUserByUsername:

                            User userToFind = (User)request.Item;

                            User userFound = ServerController.Instance.GetUserByUsername(userToFind, new GetUserByUsernameSO(userToFind));

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
                                if (ServerController.Instance.UpdateUser(userToUpdate, new UpdateAccountSO(userToUpdate)))
                                    response.Operation = Operation.UserUpdateOk;
                                else response.Operation = Operation.UserUpdateNotOk;

                                formatter.Serialize(stream, response);
                            }

                            break;

                        case Operation.GetAllCoaches:

                            List<Coach> coaches = ServerController.Instance.GetAllCoaches(new GetAllCoachesSO());

                            response.ItemList = coaches.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllEducations:

                            List<Education> educations = ServerController.Instance.GetAllEducations(new GetAllEducationsSO());

                            response.ItemList = educations.ConvertAll(x => (object)x);
                            formatter.Serialize(stream, response);

                            break;

                        case Operation.DeleteCoach:

                            Coach resToDelete = (Coach)request.Item;

                            ServerController.Instance.DeleteCoach(resToDelete, new DeleteCoachSO(resToDelete));

                            response.Operation = Operation.UpdateCoachOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllGroups:

                            List<Group> groups = ServerController.Instance.GetAllGroups(new GetAllGroupsSO());

                            response.ItemList = groups.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.UpdateCoach:

                            Coach resToUpdate = (Coach)request.Item;

                            if(ServerController.Instance.UpdateCoach(resToUpdate, new UpdateCoachSO(resToUpdate)))
                                response.Operation = Operation.UpdateCoachOk;
                            else
                                response.Operation = Operation.UpdateCoachNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddCoach:

                            Coach coach = (Coach)request.Item;

                            if(ServerController.Instance.CreateCoach(coach, new CreateCoachSO(coach)))
                                response.Operation = Operation.AddCoachOk;
                            else
                                response.Operation = Operation.AddCoachNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllClients:

                            List<Client> clients = ServerController.Instance.GetAllClients(new GetAllClientsSO());

                            response.ItemList = clients.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.DeleteClient:

                            Client clientToDelete = (Client)request.Item;

                            ServerController.Instance.DeleteClient(clientToDelete, new DeleteClientSO(clientToDelete));

                            response.Operation = Operation.UpdateClientOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.UpdateClient:

                            Client clientToUpdate = (Client)request.Item;

                            if(ServerController.Instance.UpdateClient(clientToUpdate, new UpdateClientSO(clientToUpdate)))
                                response.Operation = Operation.UpdateClientOk;
                            else
                                response.Operation = Operation.UpdateClientNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddClient:

                            Client client = (Client)request.Item;

                            if(ServerController.Instance.CreateClient(client, new CreateClientSO(client)))
                                response.Operation = Operation.AddClientOk;
                            else
                                response.Operation = Operation.AddClientNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddAppointment:

                            Appointment appointment = (Appointment)request.Item;

                            if(ServerController.Instance.CreateAppointment(appointment, new CreateAppointmentSO(appointment)))
                            response.Operation = Operation.AddAppointmentOk;
                            else
                            response.Operation = Operation.AddAppointmentNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllAppointments:

                            List<Appointment> appointments = ServerController.Instance.GetAllAppointments(new GetAllAppointmentsSO());

                            response.ItemList = appointments.ConvertAll(x => (object)x);
                            formatter.Serialize(stream, response);

                            break;

                        case Operation.DeleteAppointment:

                            Appointment appToDelete = (Appointment)request.Item;

                            ServerController.Instance.DeleteAppointment(appToDelete, new DeleteAppointmentSO(appToDelete));

                            response.Operation = Operation.UpdateAppointmentOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.UpdateAppointment:

                            Appointment appToUpdate = (Appointment)request.ItemList[0];

                            ServerController.Instance.UpdateAppointment(appToUpdate, new UpdateAppointmentSO(appToUpdate));

                            response.Operation = Operation.UpdateAppointmentOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.GetAllAttendances:

                            List<Attendance> attendances = ServerController.Instance.GetAllAttendances(new GetAllAttendanceSO());

                            response.ItemList = attendances.ConvertAll(x => (object)x);

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddGroup:

                            Group group = (Group)request.Item;

                            if(ServerController.Instance.CreateGroup(group, new CreateGroupSO(group)))
                                response.Operation = Operation.AddGroupOk;
                            else
                                response.Operation = Operation.AddGroupNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.AddAttendances:

                            List<Attendance> listAttendances = new List<Attendance>();
                            foreach(Attendance item in request.ItemList)
                                listAttendances.Add(item);

                            if(ServerController.Instance.CreateAttendances(listAttendances, new CreateAttendancesSO(listAttendances)))
                                response.Operation = Operation.AddAttendancesOk;
                            else
                                response.Operation = Operation.AddAttendancesNotOk;

                            formatter.Serialize(stream, response);

                            break;

                        case Operation.DeleteAttendance:

                            Attendance attToDelete = (Attendance)request.Item;

                            ServerController.Instance.DeleteAttendance(attToDelete, new DeleteAttendanceSO(attToDelete));

                            response.Operation = Operation.UpdateAttendanceOk;

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