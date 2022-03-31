using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public class Event
	{
		private string _eventName;
		private DateTime _eventDate;
		private double _cost;
		private TimeSpan _openTime;
		private TimeSpan _endTime;
		private string _description;
		private string eventType;

		public Event(string name, DateTime date, double cost, TimeSpan openTime, TimeSpan closeTime, string description, string type)
		{
			_eventName = name;
			_eventDate = date;
			_cost = cost;
			_openTime = openTime;
			_endTime = closeTime;
			_description = description;
			eventType = type;
		}

		public string GetDescription()
		{
			throw new NotImplementedException();
		}

		public DateTime GetEventDate()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}
	}
}
