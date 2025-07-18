namespace Decorator;

/// <summary>
/// Component (as interface) for the mail service.
/// </summary>
public interface IMailService
{
    bool SendMail(string message);
}

/// <summary>
/// Concrete Component 1 that implements the IMailService interface.
/// </summary>
public class CloudMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Sending message to cloud: {message} via {nameof(CloudMailService)}");
        return true;
    }
}

/// <summary>
/// Concrete Component 2 that implements the IMailService interface.
/// </summary>
public class OnPremiseMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Sending message to on-premise server: {message} via {nameof(OnPremiseMailService)}");
        return true;
    }
}
/// <summary>
/// Decorator base class that implements the IMailService interface.
/// </summary>
public abstract class MailServiceDecoratorBase : IMailService
{
    private readonly IMailService _mailService;

    protected MailServiceDecoratorBase(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message)
    {
        return _mailService.SendMail(message);
    }
}

/// <summary>
/// Concrete Decorator that adds statistics collection functionality to the mail service.
/// </summary>
public class StatisticsDecorator : MailServiceDecoratorBase
{
    public StatisticsDecorator(IMailService mailService)
        : base(mailService)
    {
    }
    
    public override bool SendMail(string message)
    {
        Console.WriteLine($"Collecting statistics in {nameof(StatisticsDecorator)}");
        return base.SendMail(message);
    }
}

/// <summary>
/// Concrete Decorator that adds logging functionality to the mail service.
/// </summary>
public class LoggingDecorator : MailServiceDecoratorBase
{
    public LoggingDecorator(IMailService mailService)
        : base(mailService)
    {
    }
    
    public override bool SendMail(string message)
    {
        Console.WriteLine($"Logging message in {nameof(LoggingDecorator)}: {message}");
        return base.SendMail(message);
    }
}

