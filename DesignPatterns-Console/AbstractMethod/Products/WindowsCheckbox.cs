namespace DesignPatterns_Console.AbstractMethod.Products;

public class WindowsCheckbox : ICheckbox
{
    public void Render() => 
        Console.WriteLine("Rendering a Windows checkbox.");
}