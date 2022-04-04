using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public interface IDatabaseAccess
	{
		MySqlConnection MakeConnection();

		void closeConnection();
	}
}
