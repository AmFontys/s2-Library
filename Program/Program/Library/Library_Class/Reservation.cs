using Library_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public class Reservation
	{
		private DateTime _startDate;
		private DateTime _endDate;
		private int _extensionNum;

		public bool ExtendRentPeriod()
		{
			throw new NotImplementedException();
		}

		public Reservation(Item item, Account user, DateTime startDate, DateTime endDate)
		{
			throw new NotImplementedException();
		}

		public Reservation(DateTime start, DateTime end, Item item)
		{
			throw new NotImplementedException();
		}
	}
}
