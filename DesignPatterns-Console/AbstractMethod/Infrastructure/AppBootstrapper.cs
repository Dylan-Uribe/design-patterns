using DesignPatterns_Console.AbstractMethod.Client;

namespace DesignPatterns_Console.AbstractMethod.Infrastructure;

public static class AppBootstrapper
{
    public static Application Initialize()
    {
        var factory = FactoryResolver.Resolve();
        return new Application(factory);
    }
}