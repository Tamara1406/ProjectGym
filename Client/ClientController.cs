using CommunicationClasses;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        public int LoginClient(User user)
        {
            Package request = new Package
            {
                Item = user,
                Operation = Operation.LoginClient
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.LoginOk)
            {
                return 1;
            }
            else if (response.Operation == Operation.AlreadyLogged)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        internal User GetUserByUsername(User userToFind)
        {
            Package request = new Package
            {
                Operation = Operation.GetUserByUsername,
                Item = userToFind
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            return (User)response.Item;
        }

        internal bool CreateAccount(User user)
        {
            Package request = new Package
            {
                Operation = Operation.RegisterUser,
                Item = user
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.RegisterOk)
            {
                return true;
            }
            return false;
        }

        internal bool SaveAccount(User user)
        {
            ValidatorClient validator = new ValidatorClient();

            validator.CheckUserData(user);

            Package request = new Package
            {
                Item = user,
                Operation = Operation.UpdateUser
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.UserUpdateOk)
            {
                return true;
            }
            return false;
        }

        public List<Coach> GetAllCoaches()
        {
            Package request = new Package
            {
                Operation = Operation.GetAllCoaches
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
            List<Coach> coaches = response.ItemList.ConvertAll(x => (Coach)x);

            return coaches;
        }

        internal object GetCoachSearchedByName(string searchStr)
        {
            List<Coach> coaches = this.GetAllCoaches();

            List<Coach> finalCoaches = new List<Coach>();

            searchStr = searchStr.ToLower();

            foreach (Coach coach in coaches)
            {
                string name = coach.Name.ToLower();

                if (name.Contains(searchStr))
                {
                    finalCoaches.Add(coach);
                }
            }

            return finalCoaches;
        }

        internal List<Education> GetAllEducations()
        {
            Package request = new Package
            {
                Operation = Operation.GetAllEducations
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            List<Education> educations = response.ItemList.ConvertAll(x => (Education)x);

            return educations;
        }

        internal List<Coach> GetAllCoachByEducation(Education education)
        {
            Package request = new Package
            {
                Operation = Operation.GetAllCoaches,
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            List<Coach> coaches = response.ItemList.ConvertAll(x => (Coach)x);

            List<Coach> coachesByEducation = new List<Coach>();

            foreach (Coach coach in coaches)
            {
                if (coach.Education.EducationID == education.EducationID)
                {
                    coachesByEducation.Add(coach);
                }
            }

            return coachesByEducation;
        }

        internal void DeleteCoach(Coach coach)
        {
            Package request = new Package
            {
                Item = coach,
                Operation = Operation.DeleteCoach
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
        }

        public List<Group> GetAllGroups()
        {
            Package request = new Package
            {
                Operation = Operation.GetAllGroups
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
            List<Group> group = response.ItemList.ConvertAll(x => (Group)x);

            return group;
        }

        internal bool UpdateCoach(Coach coach)
        {
            Package package = new Package
            {
                Operation = Operation.UpdateCoach,
                Item = coach
            };

            Communication.SendRequest(package);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.UpdateCoachOk)
            {
                return true;
            }

            return false;
        }

        internal bool CreateCoach(Coach coach)
        {
            Package request = new Package
            {
                Operation = Operation.AddCoach,
                Item = coach
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.AddCoachOk)
            {
                return true;
            }
            return false;
        }

        public List<Domain.Client> GetAllClients()
        {
            Package request = new Package
            {
                Operation = Operation.GetAllClients
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
            List<Domain.Client> clients = response.ItemList.ConvertAll(x => (Domain.Client)x);

            return clients;
        }

        internal object GetClientSearchedByName(string searchStr)
        {
            List<Domain.Client> clients = this.GetAllClients();

            List<Domain.Client> finalClients = new List<Domain.Client>();

            searchStr = searchStr.ToLower();

            foreach (Domain.Client client in clients)
            {
                string name = client.Name.ToLower();

                if (name.Contains(searchStr))
                {
                    finalClients.Add(client);
                }
            }

            return finalClients;
        }

        internal List<Domain.Client> GetAllClientsByGroup(Group group)
        {
            Package request = new Package
            {
                Operation = Operation.GetAllClients,
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            List<Domain.Client> clients = response.ItemList.ConvertAll(x => (Domain.Client)x);

            List<Domain.Client> clientsByGroup = new List<Domain.Client>();

            foreach (Domain.Client client in clients)
            {
                if (client.Group.GroupID == group.GroupID)
                {
                    clientsByGroup.Add(client);
                }
            }

            return clientsByGroup;
        }

        internal void DeleteClient(Domain.Client client)
        {
            Package request = new Package
            {
                Item = client,
                Operation = Operation.DeleteClient
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
        }

        internal bool UpdateClient(Domain.Client client)
        {
            Package package = new Package
            {
                Operation = Operation.UpdateClient,
                Item = client
            };

            Communication.SendRequest(package);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.UpdateClientOk)
            {
                return true;
            }

            return false;
        }

        internal bool CreateClient(Domain.Client client)
        {
            Package request = new Package
            {
                Operation = Operation.AddClient,
                Item = client
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.AddClientOk)
            {
                return true;
            }
            return false;
        }

        internal bool CreateAppointment(Appointment appointment)
        {
            
            Package request = new Package
            {
                Operation = Operation.AddAppointment,
                Item = appointment
        };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.AddAppointmentOk)
            {
                return true;
            }
            return false;
        }

        public List<Appointment> GetAllAppointments()
        {
            Package request = new Package
            {
                Operation = Operation.GetAllAppointments
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
            List<Appointment> appointment = response.ItemList.ConvertAll(x => (Appointment)x);

            return appointment;
        }

        internal List<Appointment> GetAllAppointmentsByGroup(Group group)
        {
            Package request = new Package
            {
                Operation = Operation.GetAllAppointments,
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            List<Appointment> appointments = response.ItemList.ConvertAll(x => (Appointment)x);

            List<Appointment> appointmentsByGroup = new List<Appointment>();

            foreach (Appointment appointment in appointments)
            {
                if (appointment.Group.GroupID == group.GroupID)
                {
                    appointmentsByGroup.Add(appointment);
                }
            }

            return appointmentsByGroup;
        }

        internal void DeleteAppointment(Appointment appointment)
        {
            Package request = new Package
            {
                Item = appointment,
                Operation = Operation.DeleteAppointment
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
        }

        public List<Attendance> GetAllAttendances()
        {
            Package request = new Package
            {
                Operation = Operation.GetAllAttendances
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
            List<Attendance> attendances = response.ItemList.ConvertAll(x => (Attendance)x);

            return attendances;
        }

        internal bool CreateGroup(Group group)
        {
            Package request = new Package
            {
                Operation = Operation.AddGroup,
                Item = group
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.AddGroupOk)
            {
                return true;
            }
            return false;
        }

        internal bool CreateAttendances(List<Attendance> attendances)
        {
            List<object> list = new List<object>();
            foreach (object attendance in attendances)
            {
                list.Add(attendance);
            }
            Package request = new Package
            {
                Operation = Operation.AddAttendances,
                ItemList = list
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();

            if (response.Operation == Operation.AddAttendancesOk)
            {
                return true;
            }
            return false;
        }


        internal void DeleteAttendance(Attendance attendance)
        {
            Package request = new Package
            {
                Item = attendance,
                Operation = Operation.DeleteAttendance
            };

            Communication.SendRequest(request);

            Package response = Communication.RecieveResponse();
        }


    }
}
