﻿namespace DesignPatterns_Console.AbstractMethod.Products;

public class WindowsButton : IButton
{
    public void Render() => 
        Console.WriteLine("Rendering a Windows button.");
}