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
    public class EducationRepository : AbstractBaseRepository
    {
        public override void Create(AbsEntity entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(AbsEntity entity, int key)
        {
            throw new NotImplementedException();
        }

        public override List<AbsEntity> GetAll(AbsEntity entity)
        {
            BrokerController.Instance.OpenConnection();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName} " + entity.JoinKeys();

            SqlDataReader reader = command.ExecuteReader();

            List<AbsEntity> educations = entity.ReaderRead(reader);

            BrokerController.Instance.CloseConnection();

            return educations;
        }

        public override AbsEntity Load(AbsEntity entity, int key)
        {
            throw new NotImplementedException();
        }

        public override void Update(AbsEntity entity, int key)
        {
            throw new NotImplementedException();
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
