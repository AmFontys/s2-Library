using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Library.Class
{
	public class Account
	{
		private string _fname { get; set; }		
		private string _lname { get; set; }
		private string _email { get; set; }
		private string _telephone { get; set; }		
		private string _street { get; set; }		
		private string _houseNum { get; set; }		
		private string _zipcode { get; set; }		
		private string _city { get; set; }
		private string _password { get; set; }		
		private string _keyword;		
		private string _card;


		MySqlCommand _command = new MySqlCommand();
		public string GetKeyword()
		{
			return _keyword;
		}
		
		public Account(string fname, string lname, string email, string telephone, string street, string housenum, string zipcode, string city, string password)
		{
			_fname=fname;
			_lname=lname;
			_email=email;
			_telephone=telephone;
			_street=street;
			_houseNum=housenum;
			_zipcode=zipcode;
			_city=city;
			byte[] salt = GenerateKeyWord();
			_keyword = Convert.ToBase64String(salt);
			_password=GeneratePassword(salt,password);
			_card = GenerateCard();
		}

        private static string GeneratePassword(byte[] key, string password)
        {
			string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
			password: password,
			salt: key,
			prf: KeyDerivationPrf.HMACSHA256,
			iterationCount: 100000,
			numBytesRequested: 256 / 8));
			return hashed;
        }

        private string GenerateCard()
        {
			Random rng = new Random();
			string card = rng.Next(100000, 999999).ToString();
			//Needs to check if it exist and then genrate a new one
			if (checkGeneratedCard(card)) GenerateCard();			
			return card;
        }

		private bool checkGeneratedCard(string card)
        {
			MySqlCommand command = new();
			command.CommandText = "Select * From account where CardID=@card";
			command.Parameters.Add(new MySqlParameter("@card", card));
			DataSet data = DatabaseExecuter.ExecuteReader(command);
			return (data.Tables[0].Rows.Count > 0);
        }

        private byte[] GenerateKeyWord()
        {			
			byte[] salt = new byte[128 / 8];
			using (var rngCsp = new RNGCryptoServiceProvider())
			{
				rngCsp.GetNonZeroBytes(salt);
			}
			return salt;
        }

		public bool addAccount()
        {
			bool exist = checkIfAlreadyExist();
			if (exist) return false;
			MySqlCommand sql = new MySqlCommand();
			sql.CommandText = @"INSERT INTO `account`" +
                "(`Firstname`, `Lastname`, `Email`, `Telephone`, `Streetname`" +
                ", `housenumber`, `Zipcode`, `City`, `Password`, `Keyword`, `CardID`) " +
                "VALUES(@FirstName,@LastName,@Email,@Telephone,@Street," +
                "@HouseNumber,@Zipcode,@City,@Password,@Key,@CardID)";
			sql.Parameters.Add(new MySqlParameter("@FirstName", _fname));
			sql.Parameters.Add(new MySqlParameter("@LastName", _lname));
			sql.Parameters.Add(new MySqlParameter("@Email", _email));
			sql.Parameters.Add(new MySqlParameter("@Telephone", _telephone));
			sql.Parameters.Add(new MySqlParameter("@Street", _street));
			sql.Parameters.Add(new MySqlParameter("@HouseNumber", _houseNum));
			sql.Parameters.Add(new MySqlParameter("@Zipcode", _zipcode));
			sql.Parameters.Add(new MySqlParameter("@City", _city));
			sql.Parameters.Add(new MySqlParameter("@Password", _password));
			sql.Parameters.Add(new MySqlParameter("@Key", _keyword));
			sql.Parameters.Add(new MySqlParameter("@CardID",_card));
			return DatabaseExecuter.ExecuteCommand(sql);
		}

        private bool checkIfAlreadyExist()
        {
            MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = "Select Email from account where Email=@mail";
			cmd.Parameters.Add(new MySqlParameter("@mail", _email));
			DataSet set = DatabaseExecuter.ExecuteReader(cmd);
            if (set.Tables[0].Rows.Count > 0)
				return true;
			else return false;
        }

        public void UpdateAccount()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return _fname + " " +_lname;
		}

		public static bool Login(string fname, string lname, string password)
		{

			bool exist = ExistingUsername(fname, lname, out string key);
			if (exist)
			{
				byte[] keyBytes = Convert.FromBase64String(key);
				password = GeneratePassword(keyBytes, password);
				bool validPassword = CompareGivenPassword(fname, lname, password);
				if (validPassword) return true;
				return false;
			}
			return false;
		}

		private static bool CompareGivenPassword(string fname, string lname, string password)
		{
			MySqlCommand _command = new MySqlCommand();
			_command.CommandText = "Select * From account where FirstName=@fname and LastName=@lname and Password=@pass";
			_command.Parameters.Add(new MySqlParameter("@fname", fname));
			_command.Parameters.Add(new MySqlParameter("@lname", lname));
			_command.Parameters.Add(new MySqlParameter("@pass", password));
			if (DatabaseExecuter.ExecuteReader(_command).Tables[0].Rows.Count > 0)
				return true;
			else return false;
		}

		private static bool ExistingUsername(string fname, string lname, out string key)
		{
			MySqlCommand _command = new MySqlCommand();
			_command.CommandText = "Select Keyword From account where FirstName=@name AND LastName=@lname";
			_command.Parameters.Add(new MySqlParameter("@name", fname));
			_command.Parameters.Add(new MySqlParameter("@lname", lname));
			DataSet set = DatabaseExecuter.ExecuteReader(_command);

			if (set.Tables[0].Rows.Count > 0)
			{
				key = set.Tables[0].Rows[0][0].ToString();
				return true;
			}
			else
			{
				key = "";
				return false;
			}
		}
	}
}
