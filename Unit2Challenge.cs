using System;

public class Program
{
    public void Main()
    {
		int x = 20;
        int y = 10;
		int score = 3000;
        Console.WriteLine("Score: " + score);
		ammoCount (0, x, y, score);
    }

    public void ammoCount(int value, int x, int y, int score)
    {
        if (value < 0)
        {
            var number = value + x;
            Console.WriteLine("Ammo: " + number);
        } else if (score >= 3000) {
            var number = value + x + y;
            Console.WriteLine("Ammo: " + number);
        }
    }
}