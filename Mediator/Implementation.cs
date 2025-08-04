namespace Mediator;

/// <summary>
/// Mediator interface for a chat room.
/// </summary>
public interface IChatRoom
{
    public void Register(TeamMember teamMember);
    public void Send(string from, string message);
    public void Send(string from, string to, string message);
    public void SentTo<T>(string from, string message) where T : TeamMember;
}

/// <summary>
/// Colleague
/// </summary>
public abstract class TeamMember(string name)
{
    private IChatRoom? _chatRoom;

    public string Name { get;} = name;

    public void SetChatRoom(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }
    
    public void Send(string to, string message)
    {
        _chatRoom?.Send(Name, to, message);
    }

    public void Send(string message)
    {
        _chatRoom?.Send(Name, message);
    }
    
    public void SendTo<T>(string message) where T : TeamMember
    {
        _chatRoom?.SentTo<T>(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"message {from} to {Name}: {message}");
    }
}

public class Lawyer(string name) : TeamMember(name)
{
    public override void Receive(string from, string message)
    {
        Console.WriteLine($"{nameof(Lawyer)} {Name} received: ");
        base.Receive(from, message);
    }
}

public class AccountManager(string name) : TeamMember(name)
{
    public override void Receive(string from, string message)
    {
        Console.WriteLine($"{nameof(AccountManager)} {Name} received: ");
        base.Receive(from, message);
    }
}

public class TeamChatRoom : IChatRoom
{
    private readonly Dictionary<string, TeamMember> _teamMembers = new();

    public void Register(TeamMember teamMember)
    {
        teamMember.SetChatRoom(this);
        _teamMembers.TryAdd(teamMember.Name, teamMember);
    }
    
    public void Send(string from, string to, string message)
    {
        var teamMember = _teamMembers.GetValueOrDefault(to);
        teamMember?.Receive(from, message);
    }

    public void SentTo<T>(string from, string message) where T : TeamMember
    {
        foreach (var teamMember in _teamMembers.Values.OfType<T>())
        {
            if (teamMember.Name == from) continue;
            teamMember.Receive(from, message);
        }
    }

    public void Send(string from, string message)
    {
        foreach (var teamMember in _teamMembers.Values)
        {
            if (teamMember.Name == from) continue;
            teamMember.Receive(from, message);
        }
    }
}