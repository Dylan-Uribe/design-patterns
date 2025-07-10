namespace DesignPatterns_Console.AbstractMethod.Products;

public class MacButton : IButton
{
    public void Render() => 
        Console.WriteLine("Rendering a Mac button.");
}