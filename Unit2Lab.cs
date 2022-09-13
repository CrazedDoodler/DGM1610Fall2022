using System;

public class Program
{
    public void Main()
    {
        Console.WriteLine("Welcome User!");
        DoMath(9, 10);
        Compare(13, 21);
        Compare(35, 1);
        CheckPassword("Nifty67");
        CheckPassword("Thrifty67");
    }

    public void DoMath (int value, int value2)
    {
        var number = value + value2;
        Console.WriteLine(number);
    }

    public void Compare (int value, int value2)
    {
        if(value > value2) {
            Console.WriteLine("Correct, " + value + " is greater");
        } else {
            Console.WriteLine("Sorry, " + value2 + "is greater");
        }
    }

    public void CheckPassword (string password)
    {
        if (password == "Thrifty67") {
            Console.WriteLine("Logging In...");
        } else {
            Console.WriteLine("Incorrect Password, try again");
        }
    }
}