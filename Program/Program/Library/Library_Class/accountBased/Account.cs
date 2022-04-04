using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Library_Class
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

        public static string GeneratePassword(byte[] key, string password)
        {
			string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
			password: password,
			salt: key,
			prf: KeyDerivationPrf.HMACSHA256,
			iterationCount: 100000,
			numBytesRequested: 256 / 8));
			return hashed;
        }

        public static string GenerateCard()
        {
			Random rng = new Random();
			string card = rng.Next(100000, 999999).ToString();
			//Needs to check if it exist and then genrate a new one
			if (checkGeneratedCard(card)) GenerateCard();			
			return card;
        }

		public static bool checkGeneratedCard(string card)
        {
			MySqlCommand command = new();
			DBConnection db = new DBConnection();

			command.CommandText = "Select * From account where CardID=@card";
			command.Parameters.Add(new MySqlParameter("@card", card));
			DataSet data = db.ExecuteReader(command);
			return (data.Tables[0].Rows.Count > 0);
        }

        public static byte[] GenerateKeyWord()
        {			
			byte[] salt = new byte[128 / 8];
			using (var rngCsp = new RNGCryptoServiceProvider())
			{
				rngCsp.GetNonZeroBytes(salt);
			}
			return salt;
        }

		public override string ToString()
		{
			return _fname + " " + _lname;
		}

	}
}
