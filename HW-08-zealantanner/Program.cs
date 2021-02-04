using System;

interface IBaseColors
{
    void White();
    void Black();
    void Blue();
    void Red();
    void Yellow();
}

interface ISecondaryColors : IBaseColors
{
    void Green();
    void Magenta();
}
class Color : ISecondaryColors
{
    public void White()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This text should be White"); 
    }
    public void Black()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("This text should be Black");
    }
    public void Blue()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("This text should be Blue");
    }
    public void Red()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This text should be Red");
    }
    public void Yellow()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("This text should be Yellow");
    }

    public void Green()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("This text should be Green");
    }
    public void Magenta()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("This text should be Magenta");
    }
}
class MainClass
{
    static void Main()
    {
        Color color = new Color();
        color.White();
        color.Black();
        color.Blue();
        color.Red();
        color.Yellow();
        
        color.Green();
        color.Magenta();
    }
}