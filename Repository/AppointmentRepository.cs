﻿using DBBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AppointmentRepository : AbstractBaseRepository
    {

        public override void Create(AbsEntity entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(AbsEntity entity, int key)
        {
            BrokerController.Instance.OpenConnection();
            BrokerController.Instance.BeginTransaction();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $"delete from {entity.TableName} where {entity.CheckId(key)};";
            command.Transaction = BrokerController.Instance.Transaction;

            command.ExecuteNonQuery();

            BrokerController.Instance.CommitTransaction();
            BrokerController.Instance.CloseConnection();
        }

        public override List<AbsEntity> GetAll(AbsEntity entity)
        {
            BrokerController.Instance.OpenConnection();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName} " + entity.JoinKeys();

            SqlDataReader reader = command.ExecuteReader();

            List<AbsEntity> appointments = entity.ReaderRead(reader);

            BrokerController.Instance.CloseConnection();

            return appointments;
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
            BrokerController.Instance.OpenConnection();
            BrokerController.Instance.BeginTransaction();

            SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
            command.CommandText = $" INSERT INTO {entityKey.TableName} VALUES ({entityKey.ValuesToInsert(entityKey)}); " +
                $" DECLARE @PoslednjiGroupID INT; " +
                $" SET @PoslednjiGroupID = SCOPE_IDENTITY(); " +
                $" INSERT INTO {entity.TableName} VALUES ({entity.ValuesToInsert(entity)}, @PoslednjiGroupID); ";
            command.Transaction = BrokerController.Instance.Transaction;
            command.ExecuteNonQuery();

            BrokerController.Instance.CommitTransaction();
            BrokerController.Instance.CloseConnection();
        }

        public override void UpdateComplex(AbsEntity entity, int key, AbsEntity entity2, int key2)
        {
            try
            {
                BrokerController.Instance.OpenConnection();
                BrokerController.Instance.BeginTransaction();

                SqlCommand command = BrokerController.Instance.Connection.CreateCommand();
                command.CommandText = $" update {entity2.TableName} set {entity2.ValuesToSet(entity2)} where {entity2.CheckId(key2)}; " +
                    $" update {entity.TableName} set {entity.ValuesToSet(entity)} where {entity.CheckId(key)}; ";
                command.Transaction = BrokerController.Instance.Transaction;

                command.ExecuteNonQuery();

                BrokerController.Instance.CommitTransaction();
            }
            catch (SqlException ex)
            {
                BrokerController.Instance.RollbackTransaction();
                throw ex;
            }
            finally { BrokerController.Instance.CloseConnection(); }
        }
    }
}
