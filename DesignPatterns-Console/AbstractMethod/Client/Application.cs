using DesignPatterns_Console.AbstractMethod.Factories;
using DesignPatterns_Console.AbstractMethod.Products;

namespace DesignPatterns_Console.AbstractMethod.Client;

public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;
    
    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }
    
    public void Run()
    {
        _button.Render();
        _checkbox.Render();
    }
}