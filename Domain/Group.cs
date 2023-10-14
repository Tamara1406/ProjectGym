using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Group : AbsEntity
    {
        public int GroupID { get; set; }
        public Coach Coach { get; set; }

        public override string ToString()
        {
            return GroupID + "";
        }

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
