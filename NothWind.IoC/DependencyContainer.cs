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
    public static IServiceCollection AddNorthWinsServices(this IServiceCollection services)
    {
        services.AddDebugWriter();
        services.AddServices();
        return services;
    }

 

}

