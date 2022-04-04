using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library.Class
{
	public class DBConnection : IDatabaseAccess
	{
		public MySqlConnection MakeConnection()
		{
			throw new NotImplementedException();
		}

		public void closeConnection()
		{
			throw new NotImplementedException();
		}

		public int ExecuteNoNQuery(MySqlCommand query)
		{
			throw new NotImplementedException();
		}

		public DataSet ExecuteReader(MySqlCommand query)
		{
			throw new NotImplementedException();
		}
	}
}
