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
        LoginNotOk,
        AlreadyLogged,
        AddCoach,
        AddCoachOk,
        AddCoachNotOk,
        UpdateCoach,
        GetCoach,
        GetAllCoaches, 
        GetAllGroups,
        DeleteCoach,
        UpdateCoachOk,
        UpdateCoachNotOk,
        AddClient,
        AddClientOk,
        AddClientNotOk,
        UpdateClient,
        GetAllClients,
        DeleteClient,
        UpdateClientOk,
        UpdateClientNotOk,
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
        AddGroupNotOk,
        RegisterUser,
        RegisterOk,
        RegisterNotOk,
        GetUserByUsername,
        UpdateUser,
        UserUpdateOk,
        DeleteUser,
        DeleteUserOk,
        RemoveUser,
        UserUpdateNotOk,
    }
}
