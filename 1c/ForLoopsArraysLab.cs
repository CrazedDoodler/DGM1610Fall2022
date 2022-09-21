using System;

public class Program
{
    public static void Main()
    {
        string[] chessPiece = {"Bishop", "Queen", "King"};
		chessPiece[0] = "Rook"; //remove to make all "Rook"
        // for (var i = 0; i < chessPiece.Length ; i++) // to make all "Rook"
        //{
            //chessPiece[i] = "Rook";
        //}
		
		foreach(var chess in chessPiece)
		{
			Console.WriteLine(chess);
		}
    }
}