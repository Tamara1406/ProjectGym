using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment : AbsEntity
    {
        public int AppointmentID { get; set; }
        public DateTime Time { get; set; }
        public int NumberOfTerms { get; set; }
        public Group Group { get; set; }

        public override string TableName => throw new NotImplementedException();

        public override string CheckAttribute(AbsEntity entity)
        {
            throw new NotImplementedException();
        }

        public override string CheckId(int key)
        {
            throw new NotImplementedException();
        }

        public override string JoinKeys()
        {
            throw new NotImplementedException();
        }

        public override List<AbsEntity> ReaderRead(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public override string ValuesToInsert(AbsEntity entity)
        {
            throw new NotImplementedException();
        }

        public override string ValuesToSet(AbsEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
