namespace ChainOfResponsibility;

public interface IHandler
{
    void SetNext(IHandler handler);
    void HandleTicket(Ticket ticket);
}

public abstract class HandlerBase : IHandler
{
    private IHandler? _nextHandler;

    public void SetNext(IHandler handler)
    {
        _nextHandler = handler;
    }

    public virtual void HandleTicket(Ticket ticket)
    {
        if (CanhHandleTicket(ticket))
        {
            Handle(ticket);
        }
        else if (_nextHandler is not null)
        {
            _nextHandler.HandleTicket(ticket);
        }
        else
        {
            Console.WriteLine("Ticket cannot be handled");
        }
    }

    protected abstract bool CanhHandleTicket(Ticket ticket);
    protected abstract void Handle(Ticket ticket);
}

public class Level1SupportHandler : HandlerBase
{
    protected override bool CanhHandleTicket(Ticket ticket)
    {
        return ticket.Severity.Equals(Severity.Low);
    }

    protected override void Handle(Ticket ticket)
    {
        Console.WriteLine("Level 1 support handles the ticket");
    }
}

public class Level2SupportHandler : HandlerBase
{
    protected override bool CanhHandleTicket(Ticket ticket)
    {
        return ticket.Severity.Equals(Severity.Medium);
    }

    protected override void Handle(Ticket ticket)
    {
        Console.WriteLine("Level 2 support handles the ticket");
    }
}

public class Level3SupportHandler : HandlerBase
{
    protected override bool CanhHandleTicket(Ticket ticket)
    {
        return ticket.Severity.Equals(Severity.High);
    }

    protected override void Handle(Ticket ticket)
    {
        Console.WriteLine("Level 3 support handles the ticket");
    }
}

public class Ticket
{
    public Severity Severity { get; init; }
}

public enum Severity
{
    Low,
    Medium,
    High
}
