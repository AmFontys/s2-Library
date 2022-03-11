using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public class Movie : Item
	{
		private string _subtitled;
		private string _producer;
		private int _timeÌnMin;
		private string _demographic;

		public string GetSubTitle()
		{
			throw new NotImplementedException();
		}

		public string GetProducer()
		{
			throw new NotImplementedException();
		}

		public string GetDemographic()
		{
			throw new NotImplementedException();
		}

		public Movie(string subtitle, string producer, int timeInMin, string demographic, string name, string ISBN, 
			string language, string description, double cost) : base(name, ISBN, language, description, cost)
		{
			throw new NotImplementedException();
		}

		public void UpdateItem(string name, string isbn, string language, string description, double cost, string subtitle, string producer, int timeInMin, string demographic)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}

		protected override void AddGenre()
		{
			throw new NotImplementedException();
		}
	}
}
