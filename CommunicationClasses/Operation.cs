using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationClasses
{
    public enum Operation
    {
        LoginClient,
        LoginOk,
        AddCoach,
        AddCoachOk,
        UpdateCoach,
        GetCoach,
        GetAllCoaches, 
        GetAllGroups,
        DeleteCoach,
        UpdateCoachOk,
        AddClient,
        AddClientOk,
        UpdateClient,
        GetAllClients,
        DeleteClient,
        UpdateClientOk,
        SearchClient,
        AddAppointment,
        AddAppointmentOk,
        UpdateAppointment,
        UpdateAppointmentOk,
        GetAppointment,
        GetAllAppointments,
        DeleteAppointment,
        SearchAppointment,
        GetAllEducations,
        GetAllAttendances,
        AddAttendances,
        AddAttendancesOk,
        DeleteAttendance,
        UpdateAttendanceOk,
        AddGroup,
        AddGroupOk,
        RegisterUser,
        RegisterOk,
        RegisterNotOk,
        GetUserByUsername,
        UpdateUser,
        UserUpdateOk,
        DeleteUser,
        DeleteUserOk,
        AlreadyLogged,
        RemoveUser,
        UserUpdateNotOk,
    }
}
