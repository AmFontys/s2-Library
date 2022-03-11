using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public abstract class Item
	{
		protected string _name;
		protected string _ISBN;
		protected double _cost;
		private string _language;
		private string _description;

		public string GetLanguage()
		{
			throw new NotImplementedException();
		}

		public string GetDescription()
		{
			throw new NotImplementedException();
		}

		private void SetLanguage()
		{
			throw new NotImplementedException();
		}

		private void SetDescription()
		{
			throw new NotImplementedException();
		}

		public Item(string name, string ISBN, string language, string description, double cost)
		{
			_name = name;
			_ISBN = ISBN;
			_language = language;
			_description = description;
			_cost = cost;
		}
		
		protected abstract void AddGenre();

		public void DeleteGenre(string genre)
		{
			throw new NotImplementedException();
		}
	}
}
