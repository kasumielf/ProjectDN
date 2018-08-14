using ProjectDNCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDNAuth.Interfaces
{
    public interface IAuthRepository
    {
        User SelectUser(string token);
        int InsertUser(User user);
        int UpdateUser(User user);
        int DeleteUser(User user);
    }
}
