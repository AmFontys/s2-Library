using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_Class
{
	public class Book : Item
	{
		private int _pages;
		private string _author;
		private string _publisher;

		public string GetAuthor()
		{
			return _author;
		}

		public string GetPublisher()
		{
			return _publisher;
		}

		public int GetPages()
		{
			return _pages;
		}

		public List<Genre> GetGenre()
		{
			List<Genre> genreList = new List<Genre>();

			return genreList;
		}

		public Book(int page, string author, string publisher, int id, string name, string ISBN,
			string language, string description, double cost) :
			base(id, name, ISBN, language, description, cost)
		{
			_pages = page;
			_author = author;
			_publisher = publisher;
			_name = name;
		}

		public void UpdateItem(string name, string isbn, string language, string description,
			double cost, int pages, string author, string publisher)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{this._name}: {this._author}";
		}

		protected override void AddGenre()
		{
			throw new NotImplementedException();
		}

		public static Book makeBook(DataSet data, int index)
		{
			try
			{
				int pages = Convert.ToInt32(data.Tables[0].Rows[index][6]);
				string author = Convert.ToString(data.Tables[0].Rows[index][7]);
				string publisher = Convert.ToString(data.Tables[0].Rows[index][8]);

				int id = Convert.ToInt32(data.Tables[0].Rows[index][0]);
				string name = Convert.ToString(data.Tables[0].Rows[index][1]);
				string ISBN = Convert.ToString(data.Tables[0].Rows[index][2]);
				string language = Convert.ToString(data.Tables[0].Rows[index][3]);
				string description = Convert.ToString(data.Tables[0].Rows[index][4]);
				double cost = Convert.ToDouble(data.Tables[0].Rows[index][5]);

				return new Book(pages, author, publisher, id, name, ISBN, language, description, cost);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error make book " + ex.Message);
				return null;
			}
		}

	}
}
