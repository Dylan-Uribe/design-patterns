namespace Strategy;

/// <summary>
/// strategy pattern implementation
/// </summary>
public interface IExportService
{
    void Export(Order order);
}

/// <summary>
/// Concrete strategy.
/// </summary>
public class JsonExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to JSON");
    }
}

/// <summary>
/// Concrete strategy.
/// </summary>
public class XmlExportService : IExportService
{
    public void Export(Order order)
    {
        // Logic to export order as XML
        Console.WriteLine($"Exporting {order.Name} to XML");
    }
}

/// <summary>
/// Concrete strategy.
/// </summary>
public class CsvExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to CSV");
    }
}

public class Order
{
    public string Customer { get; set; }
    public int Amount { get; set; }
    public string Name { get; set; }
    public IExportService? ExportService { get; set; }
    
    public Order(string customer, int amount, string name)
    {
        Customer = customer;
        Amount = amount;
        Name = name;
    }
    
    public void Export()
    {
        ExportService?.Export(this);
    }
}