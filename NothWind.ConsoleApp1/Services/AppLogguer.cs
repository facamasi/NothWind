using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NothWind.Entities.Interfaces;
using NothWind.Entities.ValueObjects;

namespace NothWind.ConsoleApp1.Services;
internal class AppLogguer (IEnumerable<IUserActionWriter> writers)
{
    public void WriteLog(string message)
    {
        UserAction Log = new UserAction("System", message);
        foreach (var Writer in writers)
            Writer.Write(Log);   
            
    }
 }

