using AbstractFactory.Infrastructure;

Console.WriteLine("===ABSTRACT METHOD PATTERN===");
var app = AppBootstrapper.Initialize();
app.Run();