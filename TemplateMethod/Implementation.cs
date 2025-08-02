namespace TemplateMethod;

/// <summary>
/// Abstract class defining the template method pattern for parsing mail.
/// </summary>
public abstract class MailParser
{
    protected virtual void FindServer()
    {
        Console.WriteLine("Finding server...");
    }

    protected abstract void AuthenticateToServer();
    
    private string ParseHtmlMailBody(string identifier)
    {
        Console.WriteLine("Parsing HTML mail body...");
        return $"Parsed HTML content for {identifier}";
    }

    public string ParseMailBody(string identifier)
    {
        Console.WriteLine("Parsing mail body... (in template method)");
        FindServer();
        AuthenticateToServer();
        return ParseHtmlMailBody(identifier);
    }
}

public class ExchangeMailParser : MailParser
{
    protected override void AuthenticateToServer()
    {
        Console.WriteLine("Authenticating to Exchange server...");
    }
}

public class ApacheMailServer : MailParser
{
    protected override void AuthenticateToServer()
    {
        Console.WriteLine("Authenticating to Apache server...");
    }
}

public class EudoraMailServer : MailParser
{
    protected override void FindServer()
    {
        Console.WriteLine("Finding Eudora server...");
    }

    protected override void AuthenticateToServer()
    {
        Console.WriteLine("Authenticating to Eudora server...");
    }
}

