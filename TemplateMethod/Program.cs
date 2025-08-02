using TemplateMethod;

var exchangeParser = new ExchangeMailParser();
Console.WriteLine(exchangeParser.ParseMailBody(Guid.NewGuid().ToString()));
Console.WriteLine();

var apacheParser = new ApacheMailServer();
Console.WriteLine(apacheParser.ParseMailBody(Guid.NewGuid().ToString()));
Console.WriteLine();

var eudoraParser = new EudoraMailServer();
Console.WriteLine(eudoraParser.ParseMailBody(Guid.NewGuid().ToString()));
Console.WriteLine();