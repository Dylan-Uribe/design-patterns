namespace AbstractMethod.Products;

public class MacCheckbox : ICheckbox
{
    public void Render() => 
        Console.WriteLine("Rendering a Mac checkbox.");
}