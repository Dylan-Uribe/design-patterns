using DesignPatterns_Console.AbstractMethod.Products;

namespace DesignPatterns_Console.AbstractMethod.Factories;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}