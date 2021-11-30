using System;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
        CultureInfo cI = new CultureInfo("en-US", false);
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: {0}", string.Format("{0:0.00%}", percent));
        Console.WriteLine("Currency: {0}", currency.ToString("C2").Replace(" ", string.Empty));
	}
}

