//FactoryMethod
using DesignPatterns_Console.FactoryMethod.DocumentationSystem.Client;
using DesignPatterns_Console.FactoryMethod.NotificationSystem.Client;
using DesignPatterns_Console.FactoryMethod.VehicleSystem.Client;
/*Console.WriteLine("===FACTORY METHOD PATTERN===");
Notification.Run();
Console.WriteLine("------------------------------------");
Vehicle.Run();
Console.WriteLine("------------------------------------");
Document.Run();*/

//Singleton
using DesignPatterns_Console.Singleton;
/*Console.WriteLine("===SINGLETON PATTERN===");
Client.Run();
Console.WriteLine("------------------------------------");*/
//AbstractMethod
using DesignPatterns_Console.AbstractMethod.Infrastructure;
using DesignPatterns_Console.AbstractMethod.Client;
/*Console.WriteLine("===ABSTRACT METHOD PATTERN===");
var app = AppBootstrapper.Initialize();
app.Run();*/

//BuilderMethod
using DesignPatterns_Console.BuilderMethod.Client;
Console.WriteLine("===BUILDER METHOD PATTERN===");
ReportClient.Run();