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
		static MySqlCommand cmd = new MySqlCommand();
		static DBConnection dBConnection = new DBConnection();


		#region login
		public static bool Login(string email, string password, out string role,out string idUser)
		{
			role = "User";
			idUser = "-1";
			bool exist = ExistingEmail(email, out string key);
			if (exist)
			{
				byte[] keyBytes = Convert.FromBase64String(key);
				password = Account.GeneratePassword(keyBytes, password);
				bool validPassword = CompareGivenPassword(email, password, out string id);
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
			cmd = new MySqlCommand();
			dBConnection= new DBConnection();

			cmd.CommandText = "Select Levelname from level inner join worker on worker.WorkerLevel=level.LevelID where worker.AccountID=@id";
			cmd.Parameters.Add(new MySqlParameter("@id", id));
			DataSet set = dBConnection.ExecuteReader(cmd);
			if (set.Tables[0].Rows.Count > 0)
			{
				return (string)set.Tables[0].Rows[0][0];
			}
			return "User";
		}

		private static bool CompareGivenPassword(string email, string password, out string id)
		{
			id = "";
			cmd = new MySqlCommand();
			dBConnection = new DBConnection();

			cmd.CommandText = "Select AccountID From account where Email=@mail and Password=@pass";
			cmd.Parameters.Add(new MySqlParameter("@mail", email));
			cmd.Parameters.Add(new MySqlParameter("@pass", password));
			DataSet set = dBConnection.ExecuteReader(cmd);
			if (set.Tables[0].Rows.Count > 0)
			{
				id = Convert.ToString(set.Tables[0].Rows[0][0]);
				return true;
			}
			else return false;
		}

		private static bool ExistingEmail(string email,  out string key)
		{
			cmd = new MySqlCommand();
			dBConnection= new DBConnection();

			cmd.CommandText = "Select Keyword From account where Email=@mail";
			cmd.Parameters.Add(new MySqlParameter("@mail", email));
			DataSet set = dBConnection.ExecuteReader(cmd);
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
			dBConnection = new DBConnection();

			byte[] salt = Account.GenerateKeyWord();
			string keyword = Convert.ToBase64String(salt);
			string pass = Account.GeneratePassword(salt, password);
			string card = Account.GenerateCard();

			bool exist = checkIfAlreadyExist(email);
			if (exist) return false;
			cmd = new MySqlCommand();
			cmd.CommandText = @"INSERT INTO `account`" +
				"(`Firstname`, `Lastname`, `Email`, `Telephone`, `Streetname`" +
				", `housenumber`, `Zipcode`, `City`, `Password`, `Keyword`, `CardID`) " +
				"VALUES(@FirstName,@LastName,@Email,@Telephone,@Street," +
				"@HouseNumber,@Zipcode,@City,@Password,@Key,@CardID)";
			cmd.Parameters.Add(new MySqlParameter("@FirstName", fname));
			cmd.Parameters.Add(new MySqlParameter("@LastName", lname));
			cmd.Parameters.Add(new MySqlParameter("@Email", email));
			cmd.Parameters.Add(new MySqlParameter("@Telephone", telephone));
			cmd.Parameters.Add(new MySqlParameter("@Street", street));
			cmd.Parameters.Add(new MySqlParameter("@HouseNumber", houseNum));
			cmd.Parameters.Add(new MySqlParameter("@Zipcode", zipcode));
			cmd.Parameters.Add(new MySqlParameter("@City", city));
			cmd.Parameters.Add(new MySqlParameter("@Password", pass));
			cmd.Parameters.Add(new MySqlParameter("@Key", keyword));
			cmd.Parameters.Add(new MySqlParameter("@CardID", card));
			if( dBConnection.ExecuteNoNQuery(cmd)>0) return true;
			else return false;
		}
		private static bool checkIfAlreadyExist(string mail)
		{
			cmd = new MySqlCommand();
			dBConnection = new DBConnection();

			cmd.CommandText = "Select Email from account where Email=@mail";
			cmd.Parameters.Add(new MySqlParameter("@mail", mail));
			DataSet set = dBConnection.ExecuteReader(cmd);
			if (set.Tables[0].Rows.Count > 0)
				return true;
			else return false;
		}

        #endregion

        public static bool UpdateAccount(int id, string fname, string lname, string email, string telephone, string street, string housenum, string zipcode, string city, string password)
		{
			cmd = new MySqlCommand();
			cmd.CommandText = "UPDATE `account` SET `Firstname`=@fname,`Lastname`=@lname,`Email`=@mail,"+
				" `Telephone`=@tel,`Streetname`=@street,`housenumber`=@houseNum,`Zipcode`=@zip," +
				" `City`=@city ";

			if (password != "" & password !=null)
            {
				byte[] salt=Account.GenerateKeyWord();
				string keyword = Convert.ToBase64String(salt);
				password= Account.GeneratePassword(salt, password);
				cmd.CommandText += ",`Password`=@pass,`Keyword`=@key ";
				cmd.Parameters.Add(new MySqlParameter("@pass", password));
				cmd.Parameters.Add(new MySqlParameter("@key", keyword));
			}

			cmd.CommandText += " WHERE AccountID=@id";

			cmd.Parameters.Add(new MySqlParameter("@id", id));
			cmd.Parameters.Add(new MySqlParameter("@fname", fname));
			cmd.Parameters.Add(new MySqlParameter("@lname",lname));
			cmd.Parameters.Add(new MySqlParameter("@mail", email));
			cmd.Parameters.Add(new MySqlParameter("@tel", telephone));
			cmd.Parameters.Add(new MySqlParameter("@street", street));
			cmd.Parameters.Add(new MySqlParameter("@houseNum",housenum));
			cmd.Parameters.Add(new MySqlParameter("@zip",zipcode));
			cmd.Parameters.Add(new MySqlParameter("@city",city));

			if (dBConnection.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		public static void DeleteAccount(int id)
		{
			throw new NotImplementedException();
		}

        #region findAccount
		public static Account FindAccount(int id)
        {
			if (id == 0 || id == null) return null;
			cmd = new MySqlCommand();
			cmd.CommandText = "Select * from account where AccountID=@id";
			cmd.Parameters.Add(new MySqlParameter("@id", id));
			DataSet data = dBConnection.ExecuteReader(cmd);
			if (data.Tables.Count < 1) return null;
            else
            {
				return new Account(
					Convert.ToString(data.Tables[0].Rows[0][1]), Convert.ToString(data.Tables[0].Rows[0][2]),
					 Convert.ToString(data.Tables[0].Rows[0][3]), Convert.ToString(data.Tables[0].Rows[0][4]),
					  Convert.ToString(data.Tables[0].Rows[0][5]), Convert.ToString(data.Tables[0].Rows[0][6]),
					 Convert.ToString(data.Tables[0].Rows[0][7]), Convert.ToString(data.Tables[0].Rows[0][8]),
					 "");
            }
        }
        #endregion

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
