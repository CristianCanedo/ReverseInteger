using System;
					
public class Program
{
	public static void Main()
	{
		int x = 123;
		int y = -123;
		int z = 120;
		int b = -120;
		
		Console.WriteLine(Reverse(x));
		Console.WriteLine(Reverse(y));
		Console.WriteLine(Reverse(z));
		Console.WriteLine(Reverse(b));
	}
	
	public static int Reverse(int x)
	{
		string xString = x.ToString();
		string reversed = String.Empty;
		bool isNegative = false;
		
		if (xString[0] == '-')
		{
			xString = xString.Substring(1);
			isNegative = true;
		}
		
		if (xString[xString.Length-1] == '0')
		{
			xString = xString.Substring(0, xString.Length-1);
		}
		
		for (int i = xString.Length-1; i >= 0; i--){
			reversed += xString[i];
		}
		
		if (isNegative)
		{
			reversed = "-" + reversed;
		}
		
		int num = int.Parse(reversed);
		
		return num;
		
	}
}
