using Library_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public abstract class ItemManagement
	{
		public void AddItem(string name, string ISBN, double cost, string language, string description, int page, string author, string publisher)
		{
			throw new NotImplementedException();
		}

		public void AddItem(string name, string ISBN, double cost, string language, string description, string subtitle, string producer, int time, string demographic)
		{
			throw new NotImplementedException();
		}

		public void UpdateItem(int id, string name, string ISBN, double cost, string language, string description, int page, string author, string publisher)
		{
			throw new NotImplementedException();
		}

		public void UpdateItem(int id, string name, string ISBN, double cost, string language, string description, string subtitle, string producer, int time, string demographic)
		{
			throw new NotImplementedException();
		}

		public static void DeleteItem(int id)
		{
			throw new NotImplementedException();
		}

		public object SearchItem(string data, char searchOn)
		{
			throw new NotImplementedException();
		}

		public List<Book> GetAllItems()
		{
			throw new NotImplementedException();
		}

		public List<Movie> GetAllItem()
		{
			throw new NotImplementedException();
		}
	}
}
