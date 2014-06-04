using System;


class PrintSequence
	{
	static void Main ()
	{
		int i;
		for (i = 2; i < 11; i++) 
		{
			if ((i%2)==0)
				Console.WriteLine ("{0}",i);
			else
				Console.WriteLine ("{0}",-i);
		}
		Console.WriteLine ();
		Console.ReadLine ();
}
}