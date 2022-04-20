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
		private static MySqlCommand cmd = new MySqlCommand();
        private static IDatabaseAccess databaseAccess;

		public AccountManagement(IDatabaseAccess database)
        {
			databaseAccess = database;
        }
		
		//This login function first checks if the email exists first of all if then it
		//returns a byte array for the key and generates the password again.
		//After the generated password is done it compares the actual password with the given password and if false it does nothing further
		//If it's true it checks the accountlevel with the id that is given from the function CompareGivenPassword and
		//assigns it to the role and returns the id from the user

		#region login
		public bool Login(string email, string password, out string role,out string idUser)
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

		//This function checks what the level of the account is and returns the role in string form
		//if there is no role assigned to this person it returns user otherwise the actual level.

		private string CheckAccountLevel(string id)
		{
			cmd = new MySqlCommand();

			cmd.CommandText = "Select Levelname from level inner join worker on worker.WorkerLevel=level.LevelID where worker.AccountID=@id";
			cmd.Parameters.Add(new MySqlParameter("@id", id));
			DataSet set = databaseAccess.ExecuteReader(cmd);
			if (set.Tables.Count > 0)
			{
				return (string)set.Tables[0].Rows[0][0];
			}
			return "User";
		}

		//This compares the given password with the actual password of the user with the given email
		//If it's succesfull it returns the id of the user.
		private bool CompareGivenPassword(string email, string password, out string id)
		{
			id = "";
			cmd = new MySqlCommand();

			cmd.CommandText = "Select AccountID From account where Email=@mail and Password=@pass";
			cmd.Parameters.Add(new MySqlParameter("@mail", email));
			cmd.Parameters.Add(new MySqlParameter("@pass", password));
			//Checks if there is any rows that can be returned with the command
			DataSet set = databaseAccess.ExecuteReader(cmd);
			if (set.Tables.Count > 0)
			{
				id = Convert.ToString(set.Tables[0].Rows[0][0]);
				return true;
			}
			else return false;
		}

		//This function checks if the email exists already in the database and
		//returns a bollean and the key if the email/account exists.
		private bool ExistingEmail(string email,  out string key)
		{
			cmd = new MySqlCommand();

			cmd.CommandText = "Select Keyword From account where Email=@mail";
			cmd.Parameters.Add(new MySqlParameter("@mail", email));
			DataSet set = databaseAccess.ExecuteReader(cmd);
			key = "";

			if (set.Tables.Count <= 0) return false;
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
		//This function adds a normal account and if succesfull returns a boolean
        public bool AddAccount(string fname, string lname, string email, string telephone, string street, string houseNum, string zipcode, string city, string password)
		{
			//These 4 lines are for automatic genertating
			//First it creates a salt to add to the password to make it more secure
			//the variable keyword is used to safe the salt and this can later be used to remake the hased password
			//The third line is for creating a hashed password with the use of a password given by the user and the generated salt
			//The last line is to create a card for the user itself which is not needed but
			//in the future can be used to link it to this user and then they can reserve/rent books/movies on location.
			byte[] salt = Account.GenerateKeyWord();
			string keyword = Convert.ToBase64String(salt);
			string pass = Account.GeneratePassword(salt, password);
			string card = Account.GenerateCard();

			//This checks if there is already an account whith this email if so then it reurns false and
			//a account can't be created with this email.
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

			if( databaseAccess.ExecuteNoNQuery(cmd)>0) return true;
			else return false;
		}
		//Checks to see if the email already exists in the database
		private bool checkIfAlreadyExist(string mail)
		{
			cmd = new MySqlCommand();

			cmd.CommandText = "Select Email from account where Email=@mail";
			cmd.Parameters.Add(new MySqlParameter("@mail", mail));
			DataSet set = databaseAccess.ExecuteReader(cmd);
			if (set.Tables.Count > 0)
			{
				if (set.Tables[0].Rows.Count > 0)
					return true;
				else return false;
			}
			else return false;
		}

        #endregion
		//This function updates a regular account and can be used by every user.
        public bool UpdateAccount(int id, string fname, string lname, string email, string telephone, string street, string housenum, string zipcode, string city, string password)
		{
			cmd = new MySqlCommand();
			cmd.CommandText = "UPDATE `account` SET `Firstname`=@fname,`Lastname`=@lname,`Email`=@mail,"+
				" `Telephone`=@tel,`Streetname`=@street,`housenumber`=@houseNum,`Zipcode`=@zip," +
				" `City`=@city ";

			//If the password variable is filled in then it creates a whole new hashed password for them 
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

			if (databaseAccess.ExecuteNoNQuery(cmd) > 0) return true;
			else return false;
		}

		public void DeleteAccount(int id)
		{
			throw new NotImplementedException();
		}

        #region findAccount
		//This returns the account with the given id
		public Account FindAccount(int id)
        {
			if (id == 0 || id == null) return null;
			cmd = new MySqlCommand();
			cmd.CommandText = "Select * from account where AccountID=@id";
			cmd.Parameters.Add(new MySqlParameter("@id", id));

			DataSet data = databaseAccess.ExecuteReader(cmd);
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
