using System;
namespace constractor
{
	class Program
	{
		static void Main(string[] args)
		{
			Person P1 = new Person();
			P1.Name = "yanay";
			P1.Paddress = new Address("Ariel", "Israel", "Ramat Hagolan",31);
			Console.WriteLine(P1.getinfo());
		}
	}
}
