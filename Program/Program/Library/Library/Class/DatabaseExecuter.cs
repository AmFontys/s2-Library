using MySql.Data.MySqlClient;
using System.Data;

namespace Library.Class
{
    public class DatabaseExecuter
    {
        public static bool ExecuteCommand(MySqlCommand command)
        {
            MySqlConnection _con = new MySqlConnection(@"Server=studmysql01.fhict.local;Uid=dbi479450;Database=dbi479450;Pwd=PHPAdmin;");

            try
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                    _con.Open();
                    command.Connection = _con;
                    command.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    _con.Open();
                    command.Connection = _con;
                    command.ExecuteNonQuery();
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
                command = null;
                _con = null;
            }
        }

        public static DataSet ExecuteReader(MySqlCommand command)
        {
            MySqlConnection _con = new MySqlConnection(@"Server=studmysql01.fhict.local;Uid=dbi479450;Database=dbi479450;Pwd=PHPAdmin;");
            MySqlDataAdapter _DataAdapter = null;
            DataSet lDataSet = new DataSet();
            try
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                    _con.Open();
                    command.Connection = _con;
                    _DataAdapter = new MySqlDataAdapter(command);
                    _DataAdapter.Fill(lDataSet);
                }
                else
                {
                    _con.Open();
                    command.Connection = _con;
                    _DataAdapter = new MySqlDataAdapter(command);
                    _DataAdapter.Fill(lDataSet);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("query: {0}, errormessage: {1}", command.CommandText, ex.Message));
            }
            finally
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                }
                command = null;
                _con = null;
            }
            return lDataSet;
        }

    }
}
