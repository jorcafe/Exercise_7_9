using System;

class digits
{
	static void Main()
	{
		int onedigit = 0, twodigits = 0, threedigits = 0, morethanthree = 0;
		Console.Write("Insert a number: ");
		string e = Console.ReadLine();
		while(e!="end")
		{
			int input = Convert.ToInt32(e);
			if(input != 0)
			{
				if(input/10 == 0)
				onedigit ++;
				
				else if (input/100 == 0)
				twodigits ++;

				else if (input/1000 == 0)
				threedigits ++;
				
				else
				morethanthree ++;
			}
		
			Console.Write("Insert a number: ");
			e = Console.ReadLine();
		}
	
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", onedigit, 
		twodigits, threedigits, morethanthree); 
 	}
}

