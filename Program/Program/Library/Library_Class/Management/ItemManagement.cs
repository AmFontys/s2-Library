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
		private static DBConnection dBConnection=new();

		public static bool AddItem(string name, string ISBN, double cost, string language, string description, int page, string author, string publisher)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "INSERT INTO item (`Name`, `ISBN`, `Language`, `Description`, `cost`) VALUES (@name,@isbn,@language,@description,@cost);" +
				"INSERT INTO `bookinfo`(`ItemID`, `Pages`, `Author`, `Publisher`) VALUES (LAST_INSERT_ID(),@page,@author,@publisher);  ";
			cmd.Parameters.Add(new MySqlParameter("@name", name));
			cmd.Parameters.Add(new MySqlParameter("@isbn",ISBN));
			cmd.Parameters.Add(new MySqlParameter("@language",language));
			cmd.Parameters.Add(new MySqlParameter("@description",description));
			cmd.Parameters.Add(new MySqlParameter("@cost", cost));

			cmd.Parameters.Add(new MySqlParameter("@page", page));
			cmd.Parameters.Add(new MySqlParameter("@author",author));
			cmd.Parameters.Add(new MySqlParameter("@publisher",publisher));
			if(dBConnection.ExecuteNoNQuery(cmd)>0)return true;
			else return false;
		}

		public static bool AddItem(string name, string ISBN, double cost, string language, string description, string subtitle, string producer, int time, string demographic)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "INSERT INTO item (`Name`, `ISBN`, `Language`, `Description`, `cost`) VALUES (@name,@isbn,@language,@description,@cost);" +
				"INSERT INTO `movieinfo`(`ItemID`, `SubtitleLanguage`, `Producer`, `timeInMin`, `Demographic`) VALUES (LAST_INSERT_ID(),@subtitle,@producer,@time,@demographic)";
			cmd.Parameters.Add(new MySqlParameter("@name", name));
			cmd.Parameters.Add(new MySqlParameter("@isbn", ISBN));
			cmd.Parameters.Add(new MySqlParameter("@language", language));
			cmd.Parameters.Add(new MySqlParameter("@description", description));
			cmd.Parameters.Add(new MySqlParameter("@cost", cost));

			cmd.Parameters.Add(new MySqlParameter("@subtitle",subtitle));
			cmd.Parameters.Add(new MySqlParameter("@producer",producer));
			cmd.Parameters.Add(new MySqlParameter("@time",time));
			cmd.Parameters.Add(new MySqlParameter("@demographic", demographic));

			if (dBConnection.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		public bool UpdateItem(int id, string name, string ISBN, double cost, string language, string description, int page, string author, string publisher)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "update item set `Name`=@name, `ISBN`=@isbn, `Language`=@language, `Description`=@description, `cost`=@cost where itemID=@id;" +
				"update `bookinfo` set `Pages`=@page, `Author`=@author, `Publisher`=@publisher where itemid=@id;  ";
			cmd.Parameters.Add(new MySqlParameter("@id", id));
			cmd.Parameters.Add(new MySqlParameter("@name", name));
			cmd.Parameters.Add(new MySqlParameter("@isbn", ISBN));
			cmd.Parameters.Add(new MySqlParameter("@language", language));
			cmd.Parameters.Add(new MySqlParameter("@description", description));
			cmd.Parameters.Add(new MySqlParameter("@cost", cost));

			cmd.Parameters.Add(new MySqlParameter("@page", page));
			cmd.Parameters.Add(new MySqlParameter("@author", author));
			cmd.Parameters.Add(new MySqlParameter("@publisher", publisher));
			if (dBConnection.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		public bool UpdateItem(int id, string name, string ISBN, double cost, string language, string description, string subtitle, string producer, int time, string demographic)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "update item set `Name`=@name, `ISBN`=@isbn, `Language`=@language, `Description`=@description, `cost`=@cost where itemID=@id;" +
				"UPDATE `movieinfo` SET `SubtitleLanguage`=@subtitle,`Producer`=@producer,`timeInMin`=@time,`Demographic`=@demographic WHERE itemid=@id";
			cmd.Parameters.Add(new MySqlParameter("@id", id));
			cmd.Parameters.Add(new MySqlParameter("@name", name));
			cmd.Parameters.Add(new MySqlParameter("@isbn", ISBN));
			cmd.Parameters.Add(new MySqlParameter("@language", language));
			cmd.Parameters.Add(new MySqlParameter("@description", description));
			cmd.Parameters.Add(new MySqlParameter("@cost", cost));

			cmd.Parameters.Add(new MySqlParameter("@subtitle", subtitle));
			cmd.Parameters.Add(new MySqlParameter("@producer", producer));
			cmd.Parameters.Add(new MySqlParameter("@time", time));
			cmd.Parameters.Add(new MySqlParameter("@demographic", demographic));
			if (dBConnection.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		public static int DeleteItem(int? id)
		{
			if(id ==null | id<1) return 0;
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "DELETE FROM `bookinfo` WHERE itemId=@id;" +
				"DELETE FROM `movieinfo` WHERE itemId=@id;" +
				"DELETE FROM `item` WHERE itemID=@id;";
			cmd.Parameters.Add(new MySqlParameter("@id", id));
			return dBConnection.ExecuteNoNQuery(cmd);
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

		public static List<Book> GetAllItems()
		{
			List<Book> booklist = new();
			MySqlCommand command = new MySqlCommand();
			DBConnection db = new DBConnection();

			command.CommandText = "SELECT `item`.*, `bookinfo`.`Pages`, `bookinfo`.`Author`, `bookinfo`.`Publisher` " +
					"FROM `item` RIGHT JOIN `bookinfo` ON `bookinfo`.`ItemID` = `item`.`ItemID`";
			DataSet ds = db.ExecuteReader(command);
			if (ds.Tables.Count > 0)
			{
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					booklist.Add(Book.makeBook(ds, i));
				}
			}
			return booklist;
		}

		public static List<Movie> GetAllItem()
		{
			List<Movie> movielist = new();
			MySqlCommand command = new MySqlCommand();
			DBConnection dBConnection = new DBConnection();

			command.CommandText = "SELECT `item`.*, `movieinfo`.`SubtitleLanguage`, `movieinfo`.`Producer`, " +
				"`movieinfo`.`timeInMin`, `movieinfo`.`Demographic` " +
				"FROM `item` RIGHT JOIN `movieinfo` ON `movieinfo`.`ItemID` = `item`.`ItemID`; ";
			DataSet ds = dBConnection.ExecuteReader(command);
			if (ds.Tables.Count > 0)
			{
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					movielist.Add(Movie.MakeMovie(ds, i));
				}
			}
			return movielist;
		}
	}
}
