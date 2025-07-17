using AbstractMethod.Factories;

namespace AbstractMethod.Infrastructure;

public static class FactoryResolver
{
    public static IGUIFactory Resolve()
    {
        var os = GetOS();
        return os switch
        {
            "Windows" => new WindowsFactory(),
            "MacOS" => new MacFactory(),
            _ => throw new NotSupportedException($"Operating system '{os}' is not supported.")
        };
    }

    private static string GetOS()
    {
        const string path = "Real/Path/To/Your/ConfigFile.txt";
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("Configuration file not found.", path);
        }
        return File.ReadAllText(path).Trim();
    }
}