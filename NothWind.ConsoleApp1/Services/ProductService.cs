using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NothWind.Entities.Interfaces;
using NothWind.Entities.ValueObjects;

namespace NothWind.ConsoleApp1.Services;
internal class ProductService (IUserActionWriter writer)
{
    public void Add(string user, string productName)
    {
        UserAction Action = new UserAction(user, $"Created: {productName}");
        writer.Write(Action);
    }
}
