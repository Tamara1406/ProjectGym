using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClientSO
{
    public class CreateClientSO : BaseSO
    {
        Client client;
        public CreateClientSO(Client client)
        {
            repository = new ClientRepository();
            this.client = client;
        }
        protected override void ExecuteConcreteOperation()
        {
            repository.Create(client);
        }
    }
}
