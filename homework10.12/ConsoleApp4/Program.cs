using System;
namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			string currentYear = DateTime.Now.Year.ToString();
			int Year=Convert.ToInt32(currentYear);
			Food[] list = new Food[5];
			list[0] = new Food("Bamba",5,true,"osem",2017);
			list[1] = new Food("Ice cream",10, false, "nestle", 2018);
			list[2] = new Food("Hot Dog",35, false, "yanay", 2019);
			list[3] = new Food("Hamborger",55, true, "yager", 2017);
			list[4] = new Food("Pocporen", 47, true, "cinima",2020);
			for (int i = 0; i < list.Length; i++)
			{
				Console.WriteLine($"---------------------------------Product No.{i+1}-----------------------------------");
				list[i].print_prudect();
				if (list[i].Expiry_Date(Year))
					Console.WriteLine("The date is good.");
				else
					Console.WriteLine("***The product date is not good.***");
			}
		}
	}
}
