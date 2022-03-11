using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public class Book : Item
	{
		private int _pages;
		private string _author;
		private string _publisher;

		public string GetAuthor()
		{
			throw new NotImplementedException();
		}

		public string GetPublisher()
		{
			throw new NotImplementedException();
		}

		public Book(int page, string author, string publisher, string name, string ISBN, 
			string language, string description, double cost) : 
			base(name, ISBN, language, description, cost)
		{
			_pages=page;
			_author=author;
			_publisher=publisher;
			_name=name;
		}

		public void UpdateItem(string name, string isbn, string language, string description,
			double cost, int pages, string author, string publisher)
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
