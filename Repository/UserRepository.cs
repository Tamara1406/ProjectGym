using DBBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : AbstractBaseRepository
    {

        public override void Create(AbsEntity entity)
        {
            BrokerController.Instance.OpenConnection();
            BrokerController.Instance.BeginTransaction();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $"insert into {entity.TableName} values ({entity.ValuesToInsert(entity)})";
            command.Transaction = BrokerController.Instance.Transaction;
            command.ExecuteNonQuery();

            BrokerController.Instance.CommitTransaction();
            BrokerController.Instance.CloseConnection();
        }

        public override void Delete(AbsEntity entity, int key)
        {
            throw new NotImplementedException();
        }

        public override List<AbsEntity> GetAll(AbsEntity entity)
        {
            BrokerController.Instance.OpenConnection();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName};";

            SqlDataReader reader = command.ExecuteReader();
            List<AbsEntity> users = entity.ReaderRead(reader);

            BrokerController.Instance.CloseConnection();

            return users;
        }

        public override AbsEntity Load(AbsEntity entity, int key)
        {
            BrokerController.Instance.OpenConnection();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName} where {entity.CheckAttribute(entity)};";

            SqlDataReader reader = command.ExecuteReader();
            List<AbsEntity> users = entity.ReaderRead(reader);

            BrokerController.Instance.CloseConnection();

            return users[0];
        }

        public override void Update(AbsEntity entity, int key)
        {
            BrokerController.Instance.OpenConnection();
            BrokerController.Instance.BeginTransaction();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $"update {entity.TableName} set {entity.ValuesToSet(entity)} where {entity.CheckId(key)}";
            command.Transaction = BrokerController.Instance.Transaction;
            command.ExecuteNonQuery();

            BrokerController.Instance.CommitTransaction();
            BrokerController.Instance.CloseConnection();
        }

        public override List<AbsEntity> Search(AbsEntity entity, string criteria)
        {
            throw new NotImplementedException();
        }

        public override void CreateComplex(AbsEntity entity, AbsEntity entityKey)
        {
            throw new NotImplementedException();
        }

        public override void UpdateComplex(AbsEntity entity, int key, AbsEntity entity2, int key2)
        {
            throw new NotImplementedException();
        }
    }
}
