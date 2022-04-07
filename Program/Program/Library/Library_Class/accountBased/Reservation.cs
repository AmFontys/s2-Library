using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Class
{
	public class Reservation
	{
		private DateTime _startDate;
		private DateTime _endDate;
		private int _extensionNum;
		private Item _item;
		private Account _account;

		public void ExtendRentPeriod()
		{
			throw new NotImplementedException();
		}

		public Reservation(Item item, Account user, DateTime startDate, DateTime endDate)
		{
			_startDate = startDate;
			_endDate = endDate;
			_extensionNum = 0;
			_item = item;
			_account = user;
		}

		public Reservation(DateTime start, DateTime end, Item item)
		{
			_startDate = start;
			_endDate = end;
			_item = item;
		}
	}
}
