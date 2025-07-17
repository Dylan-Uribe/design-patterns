using AbstractMethod.Products;

namespace AbstractMethod.Factories;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}