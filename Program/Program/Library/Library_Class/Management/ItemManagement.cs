using Library_Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_Class
{
	public class ItemManagement
	{
		private static IDatabaseAccess databaseAccess;

		public ItemManagement(IDatabaseAccess database)
        {
			databaseAccess = database;
        }

		/* This function adds a new item this particular one is to add a book
		 * It first takes all the info needed for to create a new row in the table item
		 * Afterwards it takes the last inserted id which is named itemID and takes it to the next command
		 * Which is the command/query to add a new row in the bookinfo table.
		 */
		public bool AddItem(string name, string ISBN, double cost, string language, string description, int page, string author, string publisher)
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

			//This checks if there is any new row added and whith the returned value i check how many rows are added
			if(databaseAccess.ExecuteNoNQuery(cmd)>0)return true;
			else return false;
		}

		/* This function adds a new item this particular one is to add a Movie
		 * It first takes all the info needed for to create a new row in the table item
		 * Afterwards it takes the last inserted id which is named itemID and takes it to the next command
		 * Which is the command/query to add a new row in the movieinfo table.
		 */
		public bool AddItem(string name, string ISBN, double cost, string language, string description, string subtitle, string producer, int time, string demographic)
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

			//This checks if there is any new row added and whith the returned value i check how many rows are added
			if (databaseAccess.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		/* This function to update an item is for the updating of a book
		 * This function executes 2 commands at the same time first it executes the update in the item table 
		 * afterwards it executes the command to update the bookinfo table		 * 
		 */
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
			if (databaseAccess.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		/* This function to update an item is for the updating of a movie
		 * This function executes 2 commands at the same time first it executes the update in the item table 
		 * afterwards it executes the command to update the movieinfo table		 * 
		 */
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
			if (databaseAccess.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		/* This function deletes an item from the 3 tables where the given id is the same as their itemId
		 * I did this in one function because I think that 2 seperate functions are not possible and 
		 * you need to write the same code with one diffrence being the table name (bookinfo or movieinfo)
		 * so I reasoned that one function that deletes it from all 3 is smarter todo 
		 */
		public int DeleteItem(int? id)
		{
			//This if function checks if the id is valid otherwise it returns 0.
			if(id ==null | id<1) return 0;

			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "DELETE FROM `bookinfo` WHERE itemId=@id;" +
				"DELETE FROM `movieinfo` WHERE itemId=@id;" +
				"DELETE FROM `item` WHERE itemID=@id;";
			cmd.Parameters.Add(new MySqlParameter("@id", id));

			return databaseAccess.ExecuteNoNQuery(cmd);
		}

		//This functions based on the id given by the variable data and the searchOn whith being it a movie or a book
		public object SearchItem(int data, char searchOn)
		{
			List<Book> books = new List<Book>();
			List<Movie> movies = new List<Movie>();
			object item = null;
			MySqlCommand command = new MySqlCommand();

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
			DataSet ds = databaseAccess.ExecuteReader(command);
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

		//This function returns a list of object being it a list of Book or Movie classes.
		//It needs to have the text where it needs to search on and then the category on which it needs to search
		//The last one is for where to searchOn which can be a book or movie
		public List<object> SearchItem(string text, string category, char searchOn)
		{
			//This checks if there is any invalid charters that the user possible can type and search on
			//if there is any in the text where it needs to search on it returns null which in turn gives nothing.
			char[] InvalidChars = { '!', ',', ';', '@', '%', ':' };
			if (text.IndexOfAny(InvalidChars) >= 0) return null;

			List<object> items = new List<object>();
			MySqlCommand command = new MySqlCommand();			
			command.CommandText = "Select `item`.*  ";
			if (searchOn == 'B')
			{
				command.CommandText += ",`bookinfo`.`Pages`, `bookinfo`.`Author`, `bookinfo`.`Publisher`BookInfo FROM `item`  RIGHT JOIN `bookinfo` ON `bookinfo`.`ItemID` = `item`.`ItemID`";
			}
			else if (searchOn == 'M')
			{
				command.CommandText += ", `movieinfo`.`SubtitleLanguage`, `movieinfo`.`Producer`, " +
				"`movieinfo`.`timeInMin`, `movieinfo`.`Demographic` " +
				"FROM `item` RIGHT JOIN `movieinfo` ON `movieinfo`.`ItemID` = `item`.`ItemID` ";

			}
			command.CommandText += $"Where {category} LIKE '%{text}%'; ";
			DataSet ds = databaseAccess.ExecuteReader(command);
			if (ds.Tables.Count > 0)//Checks to see if there is at least a table where it connected to
			{
				//for every time it loops it makes a book or movie which depends on the searchOn variable and
				//adds it to the items list which consists of objects
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					if (searchOn == 'B')
						items.Add(Book.makeBook(ds, i));
					else
						items.Add(Movie.MakeMovie(ds, i));
				}
			}
			return items;
        }
		//This function returns a list of books based on if the itemid from item and the itemid from bookinfo are the same
		public List<Book> GetAllItems()
		{
			List<Book> booklist = new();
			MySqlCommand command = new MySqlCommand();

			command.CommandText = "SELECT `item`.*, `bookinfo`.`Pages`, `bookinfo`.`Author`, `bookinfo`.`Publisher` " +
					"FROM `item` RIGHT JOIN `bookinfo` ON `bookinfo`.`ItemID` = `item`.`ItemID`";
			DataSet ds = databaseAccess.ExecuteReader(command);
			if (ds.Tables.Count > 0)
			{
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					booklist.Add(Book.makeBook(ds, i));
				}
			}
			return booklist;
		}
		//This function returns a list of movies based on if the itemid from item and the itemid from movieinfo are the same
		public List<Movie> GetAllItem()
		{
			List<Movie> movielist = new();
			MySqlCommand command = new MySqlCommand();
			DBConnection databaseAccess = new DBConnection();

			command.CommandText = "SELECT `item`.*, `movieinfo`.`SubtitleLanguage`, `movieinfo`.`Producer`, " +
				"`movieinfo`.`timeInMin`, `movieinfo`.`Demographic` " +
				"FROM `item` RIGHT JOIN `movieinfo` ON `movieinfo`.`ItemID` = `item`.`ItemID`; ";
			DataSet ds = databaseAccess.ExecuteReader(command);
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
