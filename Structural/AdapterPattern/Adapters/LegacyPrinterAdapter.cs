using Structural.AdapterPattern.Interfaces;
using Structural.AdapterPattern.Legacy;

namespace Structural.AdapterPattern.Adapters;

public class LegacyPrinterAdapter(LegacyPrinter legacyPrinter) : IPrinter
{
    public void Print(string message)
    {
        legacyPrinter.Write(message);
    }
}