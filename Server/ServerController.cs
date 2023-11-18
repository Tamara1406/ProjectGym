using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using SystemOperations.AppointmentSO;
using SystemOperations.Attendance;
using SystemOperations.ClientSO;
using SystemOperations.CoachSO;
using SystemOperations.EducationSO;
using SystemOperations.GroupSO;
using SystemOperations.UserSO;

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
        public bool LoginCheck(User user)
        {
            operation = new GetAllUsersSO();
            operation.ExecuteOperation();
            List<User> users = operation.ResultList.ConvertAll(x => (User)x);

            foreach (User checkUser in users)
            {
                if (user.Username == checkUser.Username && user.Password == checkUser.Password)
                {
                    return true;
                }
            }
            return false;
        }

        internal void RegisterUSer(User newUser)
        {
            operation = new CreateAccountSO(newUser);
            operation.ExecuteOperation();
        }

        internal User GetUserByUsername(User user)
        {
            operation = new GetUserByUsernameSO(user);
            operation.ExecuteOperation();
            return (User)operation.Result;
        }

        internal void UpdateUser(User userToUpdate)
        {
            operation = new UpdateAccountSO(userToUpdate);
            operation.ExecuteOperation();
        }

        internal List<User> GetAllUsers()
        {
            operation = new GetAllUsersSO();
            operation.ExecuteOperation();
            return operation.ResultList.ConvertAll(x => (User)x);
        }

        public List<Coach> GetAllCoaches()
        {
            operation = new GetAllCoachesSO();
            operation.ExecuteOperation();
            List<Coach> coaches = operation.ResultList.ConvertAll(x => (Coach)x);
            return coaches;
        }

        public List<Education> GetAllEducations()
        {
            operation = new GetAllEducationsSO();
            operation.ExecuteOperation();
            List<Education> education = operation.ResultList.ConvertAll(x => (Education)x);
            return education;
        }

        internal void DeleteCoach(Coach resToDelete)
        {
            operation = new DeleteCoachSO(resToDelete);
            operation.ExecuteOperation();
        }

        public List<Group> GetAllGroups()
        {
            operation = new GetAllGroupsSO();
            operation.ExecuteOperation();
            List<Group> groups = operation.ResultList.ConvertAll(x => (Group)x);
            return groups;
        }

        internal void UpdateCoach(Coach resToUpdate)
        {
            operation = new UpdateCoachSO(resToUpdate);
            operation.ExecuteOperation();
        }

        internal void CreateCoach(Coach coach)
        {
            operation = new CreateCoachSO(coach);
            operation.ExecuteOperation();
        }

        public List<Client> GetAllClients()
        {
            operation = new GetAllClientsSO();
            operation.ExecuteOperation();
            List<Client> clients = operation.ResultList.ConvertAll(x => (Client)x);
            return clients;
        }

        internal void DeleteClient(Client clientToDelete)
        {
            operation = new DeleteClientSO(clientToDelete);
            operation.ExecuteOperation();
        }

        internal void UpdateClient (Client clientToUpdate)
        {
            operation = new UpdateClientSO(clientToUpdate);
            operation.ExecuteOperation();
        }

        internal void CreateClient(Client client)
        {
            operation = new CreateClientSO(client);
            operation.ExecuteOperation();
        }

        internal void CreateAppointment(Appointment appointment, Group group)
        {
            operation = new CreateAppointmentSO(appointment, group);
            operation.ExecuteOperation();
        }

        public List<Appointment> GetAllAppointments()
        {
            operation = new GetAllAppointmentsSO();
            operation.ExecuteOperation();
            List<Appointment> appointments = operation.ResultList.ConvertAll(x => (Appointment)x);
            return appointments;
        }

        internal void DeleteAppointment(Appointment appointmentToDelete)
        {
            operation = new DeleteAppointmentSO(appointmentToDelete);
            operation.ExecuteOperation();
        }

        internal void UpdateAppointment(Appointment appToUpdate, Group groupToUpdate)
        {
            operation = new UpdateAppointmentSO(appToUpdate, groupToUpdate);
            operation.ExecuteOperation();
        }

        public List<Attendance> GetAllAttendances()
        {
            operation = new GetAllAttendanceSO();
            operation.ExecuteOperation();
            List<Attendance> attendances = operation.ResultList.ConvertAll(x => (Attendance)x);
            return attendances;
        }

        internal void CreateAttendance(Attendance attendance)
        {
            operation = new CreateAttendanceSO(attendance);
            operation.ExecuteOperation();
        }


    }
}
