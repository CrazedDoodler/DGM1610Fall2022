using System;

public class Program
{
    public void Main()
    {
        string[] disney = {"Mickey", "Minnie", "Pluto", "Donald", "Goofy"};
        Console.WriteLine(disney.Length);
        foreach(var character in disney)
        {
            Console.WriteLine("My favorite Disney character is " + character);
        }
    }
}