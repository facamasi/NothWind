using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NothWind.Entities.Interfaces;
using NothWind.Entities.ValueObjects;

namespace NothWind.ConsoleApp1.Services;
internal class AppLogguer (IUserActionWriter writer)
{
    public void WriteLog(string message) 
    { 
        UserAction Log = new UserAction("System", message);
        writer.Write(Log);
            
    }
 }

