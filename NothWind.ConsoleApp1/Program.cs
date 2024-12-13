IUserActionWriter Writer = new FileWriter();

AppLogguer  Logger = new AppLogguer(Writer);
Logger.WriteLog("Aplication started");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azúcar refinada");