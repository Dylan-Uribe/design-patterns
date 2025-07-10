using DesignPatterns_Console.AbstractMethod.Products;

namespace DesignPatterns_Console.AbstractMethod.Factories;

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}