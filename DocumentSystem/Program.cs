using DocumentSystem.Builder;
using DocumentSystem.Core;
using DocumentSystem.Factory;

var manager = DocumentManager.Instance;

while (true)
{
    Console.WriteLine("\n== Document System ==");
    Console.WriteLine("[1] Create Document");
    Console.WriteLine("[2] Clone Document");
    Console.WriteLine("[3] Build Contract");
    Console.WriteLine("[4] Show Documents");
    Console.WriteLine("[0] Exit");

    Console.Write("Choose option: ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Write("Enter title: ");
            var title = Console.ReadLine();
            Console.WriteLine("Select type: report / letter / contract");
            var type = Console.ReadLine()?.ToLower();

            DocumentCreator creator = type switch
            {
                "report" => new ReportCreator(),
                "letter" => new LetterCreator(),
                "contract" => new ContractCreator(),
                _ => throw new Exception("Unsupported type")
            };

            var doc = creator.CreateDocument(title);
            manager.AddDocument(doc);
            Console.WriteLine("Document created.");
            break;

        case "2":
            var docs = manager.GetDocuments();
            for (var i = 0; i < docs.Count; i++)
                Console.WriteLine($"[{i}] {docs[i].Title}");

            Console.Write("Select index to clone: ");
            var idx = int.Parse(Console.ReadLine() ?? string.Empty);
            var clone = manager.CloneDocument(idx);
            clone.Title += " (Clone)";
            manager.AddDocument(clone);
            Console.WriteLine("Document cloned.");
            break;

        case "3":
            var builder = new ContractBuilder();
            var director = new ContractDirector(builder);
            director.Construct();
            var contract = builder.GetContract();
            manager.AddDocument(contract);
            Console.WriteLine("Contract built.");
            break;

        case "4":
            manager.ShowAll();
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}