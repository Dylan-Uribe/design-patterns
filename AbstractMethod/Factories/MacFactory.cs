using AbstractMethod.Products;

namespace AbstractMethod.Factories;

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}