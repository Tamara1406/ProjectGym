using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClientSO
{
    public class DeleteClientSO : BaseSO
    {
        Client client;
        public DeleteClientSO(Client client)
        {
            this.client = client;
            repository = new ClientRepository();
        }
        protected override void ExecuteConcreteOperation()
        {
            repository.Delete(client, client.ClientID);
        }
    }
}
