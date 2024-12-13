using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NothWind.Entities.Interfaces;
using NothWind.Writers;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddConsoleWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, ConsoleWriter>();
        return services;
    }

    public static IServiceCollection AddDebugWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, DebugWriter>();
        return services;
    }

    public static IServiceCollection AddFileleWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, FileWriter>();
        return services;
    }

}

