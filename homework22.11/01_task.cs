using System;
namespace HomeworkClasses
{
	class car
	{
		private int speedUp;

		public int SpeedUp
		{
			get { return speedUp; }
			set { speedUp = value; }
		}

		private int speedDown;

		public int SpeedDown
		{
			get { return speedDown; }
			set { speedDown = value; }
		}

		private int carStop;

		public int CarStop
		{
			get { return carStop; }
			set { carStop = 0; }
		}
	}
	class _00_task1
	{
		static void Main(string[] args)
		{
			car car1 = new car();
			Console.WriteLine($"you speed is:{car1.CarStop},speed up:{car1.SpeedUp + 1},speed down:{car1.SpeedUp + 1}");
			Console.WriteLine("how much do you want to speed up your car?");
			car1.SpeedUp = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Your speed is:{car1.SpeedUp}");
			car1.SpeedDown -= 2;
			car1.SpeedUp += car1.SpeedDown;
			Console.WriteLine($"Your speed is:{car1.SpeedUp}");
			Console.WriteLine($"Your car stop:{car1.CarStop}");
		}
	}
}
