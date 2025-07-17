using AbstractMethod.Client;

namespace AbstractMethod.Infrastructure;

public static class AppBootstrapper
{
    public static Application Initialize()
    {
        var factory = FactoryResolver.Resolve();
        return new Application(factory);
    }
}