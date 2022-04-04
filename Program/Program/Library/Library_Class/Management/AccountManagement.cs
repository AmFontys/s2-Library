using Library_Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_Class
{
	public class AccountManagement
	{
        #region login
        public static bool Login(string fname, string lname, string password, out string role,out string idUser)
		{
			role = "User";
			idUser = "-1";
			bool exist = ExistingUsername(fname, lname, out string key);
			if (exist)
			{
				byte[] keyBytes = Convert.FromBase64String(key);
				password = Account.GeneratePassword(keyBytes, password);
				bool validPassword = CompareGivenPassword(fname, lname, password, out string id);
				if (validPassword)
				{
					role = CheckAccountLevel(id);
					idUser = id;
					return true;
				}
				return false;
			}
			return false;
		}

		private static string CheckAccountLevel(string id)
		{
			MySqlCommand command = new MySqlCommand();
			command.CommandText = "Select Levelname from level inner join worker on worker.WorkerLevel=level.LevelID where worker.AccountID=@id";
			command.Parameters.Add(new MySqlParameter("@id", id));
			DataSet set = DatabaseExecuter.ExecuteReader(command);
			if (set.Tables[0].Rows.Count > 0)
			{
				return (string)set.Tables[0].Rows[0][0];
			}
			return "User";
		}

		private static bool CompareGivenPassword(string fname, string lname, string password, out string id)
		{
			id = "";
			MySqlCommand _command = new MySqlCommand();
			_command.CommandText = "Select AccountID From account where FirstName=@fname and LastName=@lname and Password=@pass";
			_command.Parameters.Add(new MySqlParameter("@fname", fname));
			_command.Parameters.Add(new MySqlParameter("@lname", lname));
			_command.Parameters.Add(new MySqlParameter("@pass", password));
			DataSet set = DatabaseExecuter.ExecuteReader(_command);
			if (set.Tables[0].Rows.Count > 0)
			{
				id = Convert.ToString(set.Tables[0].Rows[0][0]);
				return true;
			}
			else return false;
		}

		private static bool ExistingUsername(string fname, string lname, out string key)
		{
			MySqlCommand _command = new MySqlCommand();
			_command.CommandText = "Select Keyword From account where FirstName=@name AND LastName=@lname";
			_command.Parameters.Add(new MySqlParameter("@name", fname));
			_command.Parameters.Add(new MySqlParameter("@lname", lname));
			DataSet set = DatabaseExecuter.ExecuteReader(_command);
			key = "";

			if (set.Tables.Count < 0) return false;
			if (set.Tables[0].Rows.Count > 0)
			{
				key = set.Tables[0].Rows[0][0].ToString();
				return true;
			}
			else
			{
				return false;
			}
		}
        #endregion
        #region adding an account
        public static bool AddAccount(string fname, string lname, string email, string telephone, string street, string houseNum, string zipcode, string city, string password)
		{
			byte[] salt = Account.GenerateKeyWord();
			string keyword = Convert.ToBase64String(salt);
			string pass = Account.GeneratePassword(salt, password);
			string card = Account.GenerateCard();

			bool exist = checkIfAlreadyExist(email);
			if (exist) return false;
			MySqlCommand sql = new MySqlCommand();
			sql.CommandText = @"INSERT INTO `account`" +
				"(`Firstname`, `Lastname`, `Email`, `Telephone`, `Streetname`" +
				", `housenumber`, `Zipcode`, `City`, `Password`, `Keyword`, `CardID`) " +
				"VALUES(@FirstName,@LastName,@Email,@Telephone,@Street," +
				"@HouseNumber,@Zipcode,@City,@Password,@Key,@CardID)";
			sql.Parameters.Add(new MySqlParameter("@FirstName", fname));
			sql.Parameters.Add(new MySqlParameter("@LastName", lname));
			sql.Parameters.Add(new MySqlParameter("@Email", email));
			sql.Parameters.Add(new MySqlParameter("@Telephone", telephone));
			sql.Parameters.Add(new MySqlParameter("@Street", street));
			sql.Parameters.Add(new MySqlParameter("@HouseNumber", houseNum));
			sql.Parameters.Add(new MySqlParameter("@Zipcode", zipcode));
			sql.Parameters.Add(new MySqlParameter("@City", city));
			sql.Parameters.Add(new MySqlParameter("@Password", pass));
			sql.Parameters.Add(new MySqlParameter("@Key", keyword));
			sql.Parameters.Add(new MySqlParameter("@CardID", card));
			return DatabaseExecuter.ExecuteCommand(sql);
		}
		private static bool checkIfAlreadyExist(string mail)
		{
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "Select Email from account where Email=@mail";
			cmd.Parameters.Add(new MySqlParameter("@mail", mail));
			DataSet set = DatabaseExecuter.ExecuteReader(cmd);
			if (set.Tables[0].Rows.Count > 0)
				return true;
			else return false;
		}

        #endregion

        public void UpdateAccount(int id, string fname, string lname, string email, string telephone, string street, string housenum, string zipcode, string city, string password)
		{
			throw new NotImplementedException();
		}

		public static void DeleteAccount(int id)
		{
			throw new NotImplementedException();
		}

        #region worker
        public void MakeAccountWorker(int accountId, int jobId, string bankAccount, string serviceNumber, double salary)
		{
			throw new NotImplementedException();
		}

		public void ChangeWorkerJob(int accountId, int positionId)
		{
			throw new NotImplementedException();
		}

		public void UpdateWorker(int accountId, string bankAccount, double salary)
		{
			throw new NotImplementedException();
		}

		public static void DeleteWorker(int accountId)
		{
			throw new NotImplementedException();
		}
        #endregion
        #region position
        public void AddPosition(string name, double salary)
		{
			throw new NotImplementedException();
		}

		public void UpdatePosition(int id, string name, double salary)
		{
			throw new NotImplementedException();
		}
        #endregion
        #region lists
        public List<Account> GetAllAccount()
		{
			throw new NotImplementedException();
		}

		public List<Worker> GetAccounts()
		{
			throw new NotImplementedException();
		}

		public List<Position> GetPositions()
		{
			throw new NotImplementedException();
		}
        #endregion
    }
}
