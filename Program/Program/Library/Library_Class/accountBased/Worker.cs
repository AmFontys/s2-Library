using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Class
{
	public class Worker : Account
	{
		private string _bankAccount;
		private string _citizenServiceNum;
		private double _salary;

        public Worker(string fname, string lname, string email, string telephone, string street, string housenum, string zipcode, string city, string password) : base(fname, lname, email, telephone, street, housenum, zipcode, city, password)
        {
        }

        public override string ToString()
		{
			throw new NotImplementedException();
		}
	}
}
