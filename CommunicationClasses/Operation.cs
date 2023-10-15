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
        UpdateCoach,
        GetCoach,
        DeleteCoach,
        SearchCoach,
        AddClient,
        UpdateClient,
        GetClient,
        DeleteClient,
        SearchClient,
        AddAppointment,
        UpdateAppointment,
        GetAppointment,
        DeleteAppointment,
        SearchAppointment,
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
