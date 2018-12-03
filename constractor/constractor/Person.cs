namespace constractor
{
	class Person
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private Address paddress;

		public Address Paddress
		{
			get { return paddress; }
			set { paddress = value; }
		}
		//---------constractor---------
		public Person() { }
		
		public Person(string name,Address padress)
		{
			Name = name;
			Paddress = paddress;
		}
		public string getinfo()
		{
			string res = Paddress.getinfo();
			return $"1.Person Name:{Name}\n     2.Address:\n{res}\n";
		}
	}
}
