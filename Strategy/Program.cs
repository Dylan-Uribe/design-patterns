using Strategy;

var order = new Order("Jane Doe", 100, "Order1")
{
    ExportService = new XmlExportService()
};
order.Export();

var order2 = new Order("Misil", 200, "Order2")
{
    ExportService = new JsonExportService()
};
order2.Export();

var order3 = new Order("Alicia", 300, "Order3")
{
    ExportService = new CsvExportService()
};
order3.Export();