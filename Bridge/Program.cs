using Bridge.Abstraction;
using Bridge.Implementation;

Console.WriteLine("=== Bridge Pattern Example ===\n");

var noCoupon = new NoCoupon(); // -> Discount of 0 EUR
var oneEuroCoupon = new OneEuroCoupon(); // -> Discount of 1 EUR
var meatBasedMenu = new MeatBasedMenu(noCoupon); // -> Meat menu without coupon
var vegetarianMenu = new VegetarianMenu(oneEuroCoupon); // -> Vegetarian menu with 1 EUR coupon
Console.WriteLine($"Meat Based Menu Price: {meatBasedMenu.CalculatePrice()} EUR");
Console.WriteLine($"Vegetarian Menu Price: {vegetarianMenu.CalculatePrice()} EUR");