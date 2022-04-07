using Library_Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_Class
{
	public abstract class ItemManagement
	{
		private static DBConnection dBConnection;

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

		public static object SearchItem(int data, char searchOn)
		{
			List<Book> books = new List<Book>();
			List<Movie> movies = new List<Movie>();
			object item = null;
			MySqlCommand command = new MySqlCommand();
			dBConnection = new DBConnection();
			command.CommandText = "Select `item`.*  ";
			if (searchOn == 'B')
			{
				command.CommandText += ",`bookinfo`.`Pages`, `bookinfo`.`Author`, `bookinfo`.`Publisher`BookInfo FROM `item`  RIGHT JOIN `bookinfo` ON `bookinfo`.`ItemID` = `item`.`ItemID` WHERE `bookinfo`.ItemID = @Id";
			}
			else if (searchOn == 'M')
			{
				command.CommandText += ", `movieinfo`.`SubtitleLanguage`, `movieinfo`.`Producer`, " +
				"`movieinfo`.`timeInMin`, `movieinfo`.`Demographic` " +
				"FROM `item` RIGHT JOIN `movieinfo` ON `movieinfo`.`ItemID` = `item`.`ItemID` WHERE `movieinfo`.ItemID=@Id; ";

			}
			command.Parameters.Add(new MySqlParameter("@Id", data));
			DataSet ds = dBConnection.ExecuteReader(command);
			if (ds.Tables.Count > 0)
			{
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					if (searchOn == 'B')
						item = (Book.makeBook(ds, i));
					else
						item = (Movie.MakeMovie(ds, i));
				}
			}
			return item;
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
