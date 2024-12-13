var Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<IUserActionWriter, ConsoleWriter>();
Builder.Services.AddSingleton<IUserActionWriter, FileWriter>();
Builder.Services.AddSingleton<AppLogguer>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();


AppLogguer  Logger = AppHost.Services.GetRequiredService<AppLogguer>();
Logger.WriteLog("Aplication started");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azúcar refinada");