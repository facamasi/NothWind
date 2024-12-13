using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NothWind.Entities.Interfaces;
using NothWind.Entities.ValueObjects;

namespace NothWind.Writers;
public class DebugWriter : IUserActionWriter
{
    public void Write(UserAction action)
    {
        Debug.WriteLine("ConsoleWriter: {0}, {1}, {2}", action.CreatedDateTime, action.User, action.Description);
    }
}

