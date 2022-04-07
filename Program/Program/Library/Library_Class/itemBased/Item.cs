using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Class
{
	public abstract class Item
	{
		private int _id;
		protected string _name;
		protected string _ISBN;
		protected double _cost;
		private string _language;
		private string _description;

		public int GetID()
        {
			return _id;
        }
		
		public string GetName()
        {
			return _name;
        }

		public string GetISBN()
        {
			return _ISBN;
        }
		
		public string GetLanguage()
		{
			return _language;
		}

		public string GetDescription()
		{
			return _description;
		}

		public double GetCost()
        {
			return _cost;
        }

		private void SetLanguage()
		{
			throw new NotImplementedException();
		}

		

		public Item(int id, string name, string ISBN, string language, string description, double cost)
		{
			_id=id;
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
