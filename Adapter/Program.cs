using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.Legacy;

Console.WriteLine("=== Adapter Pattern Example ===\n");
IPrinter printer = new LegacyPrinterAdapter(new LegacyPrinter());
printer.Print("Hello, from the Adapter Pattern!");