namespace TypeOperations;

class Program
{
    static void Main(string[] args)
    {
		try
		{
			IsLeapYear(2025);
			IsLeapYear(4000);
			IsLeapYear(2000);
			int a = 2;
			int b = 0;
			a= a/b;
			float w = 3/2;
			int a1 = int.Parse("1j0");
		} 
		catch(FormatException)
		{
			Console.WriteLine("oops. convert failed");
		} 
		catch(DivideByZeroException)
		{
			Console.WriteLine("oops.  tryied to divide by  0 ");
		} 
		 
		catch(Exception ex)
		{
			Console.WriteLine(55);
			Console.WriteLine(ex.Message);
			Console.WriteLine(ex.GetType());
		}
		
		int a4 = 65535;		
		char ch = checked((char) a4);
		Console.WriteLine(ch);
		
	
    }
	static void IsLeapYear(int year)
	{
		if (year<0)
		{
			throw new ArgumentException("year is incorrect");
		}
		Console.WriteLine(year % 4 == 0 && year % 100 != 0 || year % 400 == 0  
			? "Год високосный"
			: "Год обычный");	
	}
}

