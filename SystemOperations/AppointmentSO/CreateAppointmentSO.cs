using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AppointmentSO
{
    public class CreateAppointmentSO : BaseSO
    {
        Appointment appointment;
        Group group;
        public CreateAppointmentSO(Appointment appointment, Group group)
        {
            repository = new AppointmentRepository();
            this.appointment = appointment;
            this.group = group;
        }
        protected override void ExecuteConcreteOperation()
        {
            repository.CreateComplex(appointment, group);
        }
    }
}
