using System;

public class Program
{
    public void Main()
    {
		int x = 20;
        int y = 10;
        Score ();
		Ammo (0, x, y);
    }
	
	public void Score()
	{
		int points = 3;
		switch (points)
		{
			case 1:
				Console.WriteLine("Score: 1000");
				break;
			case 2:
				Console.WriteLine("Score: 2000");
				break;
			case 3:
				Console.WriteLine("Score: 3000");
				break;
	    }
    }
	
    public void Ammo(int value, int x, int y)
    {
        if (value == 0)
        {
            var number = value + x;
            Console.WriteLine("Ammo: " + number);
        }
		else if (value >= 10)
		{
            var number = value + x + y;
            Console.WriteLine("Ammo: " + number);
        }
    }
}