using Structural.AdapterPattern.Adapters;
using Structural.AdapterPattern.Interfaces;
using Structural.AdapterPattern.Legacy;
using Structural.Bridge.Abstraction;
using Structural.Bridge.Implementation;

Console.WriteLine("=== Adapter Pattern Example ===\n");
IPrinter printer = new LegacyPrinterAdapter(new LegacyPrinter());
printer.Print("Hello, from the Adapter Pattern!");

Console.WriteLine("\n------------------------------\n");

Console.WriteLine("=== Bridge Pattern Example ===\n");

var noCoupon = new NoCoupon(); // -> Discount of 0 EUR
var oneEuroCoupon = new OneEuroCoupon(); // -> Discount of 1 EUR
var meatBasedMenu = new MeatBasedMenu(noCoupon); // -> Meat menu without coupon
var vegetarianMenu = new VegetarianMenu(oneEuroCoupon); // -> Vegetarian menu with 1 EUR coupon
Console.WriteLine($"Meat Based Menu Price: {meatBasedMenu.CalculatePrice()} EUR");
Console.WriteLine($"Vegetarian Menu Price: {vegetarianMenu.CalculatePrice()} EUR");
