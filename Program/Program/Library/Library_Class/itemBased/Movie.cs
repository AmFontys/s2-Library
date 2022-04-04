using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_Class
{
	public class Movie : Item
	{
		private string _subtitled;
		private string _producer;
		private int _timeÌnMin;
		private string _demographic;

		public string GetSubTitle()
		{
			return _subtitled;
		}

		public string GetProducer()
		{
			return _producer;
		}

		public string GetDemographic()
		{
			return _demographic;
		}

		public int GetTime()
        {
			return _timeÌnMin;
        }

		public List<Genre> GetGenre()
		{
			List<Genre> genreList = new List<Genre>();

			return genreList;
		}

		public Movie(string subtitle, string producer, int timeInMin, string demographic,int id, string name, string ISBN,
			string language, string description, double cost) : base(id,name, ISBN, language, description, cost)
		{
			_subtitled = subtitle;
			_producer = producer;
			_timeÌnMin = timeInMin;
			_demographic = demographic;
		}

		public void UpdateItem(string name, string isbn, string language, string description, double cost, string subtitle, string producer, int timeInMin, string demographic)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{this._name}: {this._producer}, {this._demographic},{this._timeÌnMin}; {this.GetDescription}";
		}

		protected override void AddGenre()
		{
			throw new NotImplementedException();
		}

		private static Movie MakeMovie(DataSet data, int index)
        {
			try
			{
				string subtitle = Convert.ToString(data.Tables[0].Rows[index][6]);
				string producer = Convert.ToString(data.Tables[0].Rows[index][7]);
				int timeInMin = Convert.ToInt32(data.Tables[0].Rows[index][8]);
				string demographic = Convert.ToString(data.Tables[0].Rows[index][9]);

				int id = Convert.ToInt32(data.Tables[0].Rows[index][0]);
				string name = Convert.ToString(data.Tables[0].Rows[index][1]);
				string ISBN = Convert.ToString(data.Tables[0].Rows[index][2]);
				string language = Convert.ToString(data.Tables[0].Rows[index][3]);
				string description = Convert.ToString(data.Tables[0].Rows[index][4]);
				double cost = Convert.ToDouble(data.Tables[0].Rows[index][5]);

				return new Movie(subtitle, producer, timeInMin, demographic, id, name, ISBN, language, description, cost);
			}
			catch (Exception ex)
            {
				return null;
            }
		}

		public static List<Movie> GetAllMovies()
		{
			List<Movie> movielist = new();
			MySqlCommand command = new MySqlCommand();
			DBConnection dBConnection=new DBConnection();

			command.CommandText = "SELECT `item`.*, `movieinfo`.`SubtitleLanguage`, `movieinfo`.`Producer`, " +
				"`movieinfo`.`timeInMin`, `movieinfo`.`Demographic` " +
				"FROM `item` RIGHT JOIN `movieinfo` ON `movieinfo`.`ItemID` = `item`.`ItemID`; ";
			DataSet ds = dBConnection.ExecuteReader(command);
			if (ds.Tables.Count > 0)
			{
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					movielist.Add(MakeMovie(ds,i));
				}
			}
			return movielist;		
		}

		public static Movie SearchMovieByID(int id)
		{
			MySqlCommand command = new MySqlCommand();
			DBConnection dBConnection = new DBConnection();

			command.CommandText = "SELECT `item`.*, `movieinfo`.`SubtitleLanguage`, `movieinfo`.`Producer`, " +
				"`movieinfo`.`timeInMin`, `movieinfo`.`Demographic` " +
				"FROM `item` RIGHT JOIN `movieinfo` ON `movieinfo`.`ItemID` = `item`.`ItemID` WHERE `movieinfo`.ItemID=@Id";
			command.Parameters.Add(new MySqlParameter("@Id", id));

			DataSet ds = dBConnection.ExecuteReader(command);
			if (ds.Tables.Count > 0)
			{				
				return	(MakeMovie(ds, 0));				
			}
			return null;
		}

	}
}
