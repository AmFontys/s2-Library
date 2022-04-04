using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_Class
{
	public class DBConnection : IDatabaseAccess
	{
		private static MySqlConnection _con;
		public MySqlConnection MakeConnection()
		{
			return new MySqlConnection(@"Server=studmysql01.fhict.local;Uid=dbi479450;Database=dbi479450;Pwd=PHPAdmin;");
		}

		public void closeConnection()
		{
			_con.Close();
		}

		public bool ExecuteNoNQuery(MySqlCommand query)
		{
            MySqlConnection _con = MakeConnection();
            try
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                    _con.Open();
                    query.Connection = _con;
                    query.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    _con.Open();
                    query.Connection = _con;
                    query.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has been occured" + ex.Message);
                return false;
            }
            finally
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                }
                query = null;
                closeConnection();
            }
        }

		public DataSet ExecuteReader(MySqlCommand query)
		{
            MySqlConnection _con = MakeConnection();
            MySqlDataAdapter _DataAdapter = null;
            DataSet lDataSet = new DataSet();
            try
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                    _con.Open();
                    query.Connection = _con;
                    _DataAdapter = new MySqlDataAdapter(query);
                    _DataAdapter.Fill(lDataSet);
                }
                else
                {
                    _con.Open();
                    query.Connection = _con;
                    _DataAdapter = new MySqlDataAdapter(query);
                    _DataAdapter.Fill(lDataSet);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("query: {0}, errormessage: {1}", query.CommandText, ex.Message));
            }
            finally
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                }
                query = null;
                _con = null;
            }
            return lDataSet;
        }
	}
}
