using System;
public class Average 
{
	public static void Main()
	{
	double a=0, b, c=0, average;
	string s;
	Console.Write("Insert a mark: ");
	s=Console.ReadLine();		 
	while(s!="end")
		{  
		b=Convert.ToDouble(s);	
		c++;   //counter of numbers
		a+=b;  // sum of all the notes
		Console.Write("Insert a mark: ");
		s=Console.ReadLine();
		}
	if(c!=0)
		{
		average=a/c;
		Console.WriteLine("The average is {0}.",average);
		}
	}
}
