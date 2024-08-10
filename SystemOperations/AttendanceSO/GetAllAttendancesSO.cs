using Repository;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Attendance
{
    public class GetAllAttendancesSO : BaseSO
    {
        public GetAllAttendancesSO()
        {
        }
        protected override void ExecuteConcreteOperation()
        {
            ResultList = repository.GetAll(new Domain.Attendance());
        }
    }
}
