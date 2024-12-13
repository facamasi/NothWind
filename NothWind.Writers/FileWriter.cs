using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NothWind.Entities.Interfaces;
using NothWind.Entities.ValueObjects;

namespace NothWind.Writers;
public class FileWriter : IUserActionWriter
{ 
    public void Write(UserAction action)
    {
        File.AppendAllText("AppLogs.txt", string.Format("FileWriter: {0}, {1}, {2}",
            action.CreatedDateTime, action.User, action.Description));
    }
}