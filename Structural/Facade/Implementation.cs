namespace Facade;

public class Facade()
{
    protected Subsystem1 _subsystem1;
    protected Subsystem2 _subsystem2;

    public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2) : this()
    {
        _subsystem1 = subsystem1;
        _subsystem2 = subsystem2;
    }

    public string Operation()
    {
        var result = "Facade initializes subsystems:\n";
        result += _subsystem1.Operation1();
        result += _subsystem2.Operation2();
        result += "Facade orders subsystems to perform the action:\n";
        result += _subsystem1.Operation1();
        result += _subsystem2.Operation2();
        return result;
    }
}

public class Subsystem1
{
    public string Operation1()
    {
        return "Subsystem1: Ready!\n";
    }

    public string Operation2()
    {
        return "Subsystem1: Ready!\n";
    }
}

public class Subsystem2
{
    public string Operation1()
    {
        return "Subsystem2: Ready!\n";
    }

    public string Operation2()
    {
        return "Subsystem2: Ready!\n";
    }
}

public class Client()
{
    public static void ClientCode(Facade facade)
    {
        Console.WriteLine(facade.Operation());
    }
}