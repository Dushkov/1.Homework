using System;

class SquareRoot
	{
	static void Main ()
		{
		Console.WriteLine ("Enter a Number :");
		int Number = Convert.ToInt16 (Console.ReadLine ());
		double SquareNumber = Math.Sqrt (Number);
		Console.WriteLine ("Square Root of {0} is {1}", Number, SquareNumber);
		Console.ReadLine ();
		}
	}

