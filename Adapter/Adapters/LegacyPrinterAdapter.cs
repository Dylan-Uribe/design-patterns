using Adapter.Interfaces;
using Adapter.Legacy;

namespace Adapter.Adapters;

public class LegacyPrinterAdapter(LegacyPrinter legacyPrinter) : IPrinter
{
    public void Print(string message)
    {
        legacyPrinter.Write(message);
    }
}