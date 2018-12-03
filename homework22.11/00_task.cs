//using System;

//namespace HomeworkClasses
//{
//	class cookie
//	{
//		private bool gluten;

//		public bool Gluten
//		{
//			get { return gluten; }
//			set { gluten = value; }
//		}
//		private int numEggs;

//		public int NumEggs
//		{
//			get { return numEggs; }
//			set { numEggs = value; }
//		}

//		private double sugar;

//		public double Sugar
//		{
//			get { return sugar; }
//			set { sugar = value; }
//		}

//		private double flour;

//		public double Flour
//		{
//			get { return flour; }
//			set { flour = value; }
//		}

//		public void printCookie()
//		{
//			Console.WriteLine($"You have this amount of groceries to make a cookie:\n" +
//							  $"gluten {gluten}\n" +
//							  $"{numEggs} eggs\n" +
//							  $"{sugar} sugar\n" +
//							  $"{flour} flour\n");
//		}
//	}
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			string choice;
//			cookie[] list = new cookie[3];
//			for (int i = 0; i < 3; i++)
//			{
//				list[i] = new cookie();
//			}
//			for (int i = 0; i < 2; i++)
//			{
//				Console.WriteLine($"                 -cookie number {i + 1}-");
//				Console.WriteLine("Please enter if you want gluten in your cookie press y/n...");
//				choice = Console.ReadLine();
//				while (choice != "y" && choice != "n")
//				{
//					Console.WriteLine("Please enter again y/n!..");
//					choice = Console.ReadLine();
//				}
//				if (choice == "y")
//					list[i].Gluten = true;
//				else if (choice == "n")
//					list[i].Gluten = false;
//				Console.WriteLine("Please enter number of eggs.");
//				list[i].NumEggs = Convert.ToInt32(Console.ReadLine());
//				Console.WriteLine("Please enter sugar gram.");
//				list[i].Sugar = Convert.ToDouble(Console.ReadLine());
//				Console.WriteLine("Please enter flour gram.");
//				list[i].Flour = Convert.ToDouble(Console.ReadLine());
//				Console.Clear();
//			}
//			for (int i = 0; i < 2; i++)
//			{
//				Console.WriteLine($"cookie number -{i + 1}-");
//				list[i].printCookie();
//			}
//			list[0].Sugar = 4.5;
//			for (int i = 0; i < 2; i++)
//			{
//				Console.WriteLine($"cookie number -{i + 1}-");
//				list[i].printCookie();
//			}
//			list[1] = list[0];
//			list[1].NumEggs = 100;
//			for (int i = 0; i < 2; i++)
//			{
//				Console.WriteLine($"cookie number -{i + 1}-");
//				list[i].printCookie();
//			}
//		}
//	}
//	//At the end of the program run the cookies will be equal because
//	//we are placing the first cookie for the second
//}
