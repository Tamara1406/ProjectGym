using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AppointmentSO
{
    public class UpdateAppointmentSO : BaseSO
    {
        Appointment appointment;
        Group group;
        public UpdateAppointmentSO(Appointment appointment, Group group)
        {
            this.appointment = appointment;
            repository = new AppointmentRepository();
            this.group = group;
        }

        protected override void ExecuteConcreteOperation()
        {
            repository.UpdateComplex(appointment, appointment.AppointmentID, group, group.GroupID);
        }
    }
}
