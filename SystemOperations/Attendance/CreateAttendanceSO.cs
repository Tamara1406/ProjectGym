using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Attendance
{
    public class CreateAttendanceSO : BaseSO
    {
        Domain.Attendance attendance;
        public CreateAttendanceSO(Domain.Attendance attendance)
        {
            repository = new AttendanceRepository();
            this.attendance = attendance;
        }
        protected override void ExecuteConcreteOperation()
        {
            repository.Create(attendance);
        }
    }
}
