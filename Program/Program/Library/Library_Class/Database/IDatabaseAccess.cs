using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_Class
{
	public interface IDatabaseAccess
	{
		MySqlConnection MakeConnection();

		void closeConnection();
        int ExecuteNoNQuery(MySqlCommand cmd);
        DataSet ExecuteReader(MySqlCommand command);
    }
}
