// See https://aka.ms/new-console-template for more information
using MiddleMan.App;

Console.WriteLine("Hello, World!");
var calculatorHandler = new CalculatorHandler();
Console.WriteLine($"Calculator handler: {calculatorHandler.Handle()}");
Console.ReadLine();