namespace constractor
{
	class Address
	{
		private string city;

		public string City
		{
			get { return city; }
			set { city = value; }
		}

		private string country;

		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		private string street;

		public string Street
		{
			get { return street; }
			set { street = value; }
		}

		private int numOfhouse;

		public int NumOfhouse
		{
			get { return numOfhouse; }
			set { numOfhouse = value;}
		}

		//---------constractor---------
		public Address(string city,string country,string street,int numOfhouse)
		{
			City = city;
			Country = country;
			Street = street;
			NumOfhouse = numOfhouse;
		}
		//---------methos----------
		public string getinfo()
		{
			return $"     2.1 City is :{city}.\n" +
				   $"     2.2 Country is :{country}.\n" +
				   $"     2.3 Street is :{street}.\n" +
				   $"     2.4 Number of house is :{numOfhouse}.";
		}
		
	}
}
