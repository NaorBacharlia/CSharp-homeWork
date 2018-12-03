using System;
namespace homework26._11
{
	public class Clock
	{
		private int hours;
		private int minutes;
		private int seconds;
		private int Milliseconds;
		public void tick()
		{
			Milliseconds = Milliseconds + 1;
			seconds = seconds + Milliseconds/1000;
			minutes = minutes + seconds / 60;
			hours = hours + minutes / 60;
			Milliseconds = Milliseconds % 1000;
			seconds = seconds % 60;
			minutes=minutes % 60;
			hours = hours % 24;
		}
		public void show()
		{
			if(hours<10)
				Console.WriteLine($"The current time is: {"0"+hours}:{"0" + minutes}:{"0" + seconds}:{"0" + Milliseconds}\n");
			else
				Console.WriteLine($"The current time is: {hours}:{"0" + minutes}:{"0" + seconds}:{"0" + Milliseconds}\n");

		}
		public void setMidNight()
		{
			Milliseconds = 0;
			seconds = 0;
			minutes = 0;
			hours = 0;
			hours = 24;

		}
		public void setMidDay()
		{
			Milliseconds = 0;
			seconds = 0;
			minutes = 0;
			hours = 0;
			hours = 12;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Clock myClock = new Clock();
			myClock.show();
			myClock.tick();
			myClock.tick();
			myClock.show();
			myClock.setMidDay();
			myClock.tick();
			myClock.tick();
			myClock.tick();
			myClock.show();
			Clock yourClock = new Clock();
			yourClock.setMidNight();
			yourClock.show();
		}
	}
}
