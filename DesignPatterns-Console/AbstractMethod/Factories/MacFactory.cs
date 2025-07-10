using DesignPatterns_Console.AbstractMethod.Products;

namespace DesignPatterns_Console.AbstractMethod.Factories;

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}