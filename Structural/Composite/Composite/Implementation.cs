namespace Composite;

/// <summary>
/// Component interface
/// </summary>
public interface IFileSystemComponent
{
    void ShowDetails();
    void Delete();
}

/// <summary>
/// Leaf
/// </summary>
public class File(string name) : IFileSystemComponent
{
    public void ShowDetails()
    {
        Console.WriteLine($"File: {name}");
    }

    public void Delete()
    {
        Console.WriteLine($"Deleting File: {name}");
    }
}

/// <summary>
/// Composite class
/// </summary>
public class Folder(string name) : IFileSystemComponent
{
    private readonly List<IFileSystemComponent> _components = new List<IFileSystemComponent>();

    public void AddComponent(IFileSystemComponent component)
    {
        _components.Add(component);
    }
    
    public void RemoveComponent(IFileSystemComponent component)
    {
        _components.Remove(component);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Folder: {name}");
        foreach (var component in _components)
        {
            component.ShowDetails();
        }
    }
    
    public void Delete()
    {
        Console.WriteLine($"Deleting folder: {name}");
        foreach (var component in _components)
        {
            component.Delete();
        }
    }
}