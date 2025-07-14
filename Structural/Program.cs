using Structural.AdapterPattern.Adapters;
using Structural.AdapterPattern.Interfaces;
using Structural.AdapterPattern.Legacy;

Console.WriteLine("Adapter Pattern Example");
IPrinter printer = new LegacyPrinterAdapter(new LegacyPrinter());
printer.Print("Hello, from the Adapter Pattern!");
