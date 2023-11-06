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
            List<Group> groupd = response.ItemList.ConvertAll(x => (Group)x);

            return groupd;
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



    }
}
