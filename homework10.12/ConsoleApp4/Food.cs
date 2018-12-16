using System;
namespace ConsoleApp4
{
	class Food
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int price;

		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		private bool kosher;

		public bool Kosher
		{
			get { return kosher; }
			set { kosher = value; }
		}

		private string manufacturer_name;

		public string Manufacturer_name
		{
			get { return manufacturer_name; }
			set { manufacturer_name = value; }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		//--------------------ctor-------------------------
		public Food(string name,int price,bool kosher,string manufacturer_name,int year)
		{
			Name = name;
			Price = price;
			Kosher = kosher;
			Manufacturer_name = manufacturer_name;
			Year = year;
		}
		//--------------------method to print the properties-------------------------
		public void print_prudect()
		{
			string k;
			if (kosher == true)
				k = "kosher";
			else
				k = "Not kosher";
			Console.WriteLine($"Name:{name}\n" +
				              $"Price:{price}\n" +
				              $"{k}\n" +
				              $"Manufacturer name:{manufacturer_name}\n" +
				              $"Expiration year:{year}\n");
		}
		//--------------------method to check if the is expiry date-------------------------
		public bool Expiry_Date(int Cuerrent_Year)
		{
			if (year < Cuerrent_Year)
				return false;
			else
				return true;
		}
	}
}
