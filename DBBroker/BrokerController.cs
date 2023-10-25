using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class BrokerController
    {
        private static BrokerController instance;
        public static BrokerController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BrokerController();
                }
                return instance;
            }
        }

        Broker broker;
        public SqlConnection Connection { get; set; }
        public SqlTransaction Transaction { get; set; }
        private BrokerController()
        {
            broker = new Broker();
            Connection = broker.Connection;
            Transaction = broker.Transaction;
        }

        public void OpenConnection()
        {
            Connection.Open();
        }
        public void CloseConnection()
        {
            Connection.Close();
        }
        public void BeginTransaction()
        {
            Transaction = Connection.BeginTransaction();
        }
        public void CommitTransaction()
        {
            Transaction.Commit();
        }
        public void RollbackTransaction()
        {
            Transaction.Rollback();
        }
    }
}
