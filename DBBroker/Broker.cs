using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        public SqlConnection Connection { get; set; }
        public SqlTransaction Transaction { get; set; }

        public Broker()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["psdb"].ConnectionString;
            string modifiedConnectionString = connectionString.Replace("\\\\", "\\");
            Connection = new SqlConnection(connectionString);
        }
    }
}
