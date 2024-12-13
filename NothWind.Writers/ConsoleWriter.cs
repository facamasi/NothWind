using NothWind.Entities.Interfaces;
using NothWind.Entities.ValueObjects;

namespace NothWind.Writers;
public class ConsoleWriter : IUserActionWriter
{
    public void Write(UserAction action)
    {
        Console.WriteLine("ConsoleWriter: {0}, {1}, {2}", action.CreatedDateTime, action.User, action.Description);
    }
}

