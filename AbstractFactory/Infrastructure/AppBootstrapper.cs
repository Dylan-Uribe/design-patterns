using AbstractFactory.Client;

namespace AbstractFactory.Infrastructure;

public static class AppBootstrapper
{
    public static Application Initialize()
    {
        var factory = FactoryResolver.Resolve();
        return new Application(factory);
    }
}