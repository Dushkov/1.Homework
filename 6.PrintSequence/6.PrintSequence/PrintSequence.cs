﻿using System;


class PrintSequence
	{
	static void Main ()
	{
		int i;
		for (i = 2; i < 12; i++) 
		{
			if ((i%2)==0)
				Console.Write("{0}",i+",");
			else
				Console.Write("{0}",-i+",");
		}
		Console.WriteLine ();
		Console.ReadLine ();
}
}