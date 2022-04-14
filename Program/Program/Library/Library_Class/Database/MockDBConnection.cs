using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Class
{
    public class MockDBConnection : IDatabaseAccess
    {
        private static MySqlConnection _con;
        public void closeConnection()
        {
            _con = null;
        }

        public int ExecuteNoNQuery(MySqlCommand cmd)
        {
            return 1;
        }

        public DataSet ExecuteReader(MySqlCommand command)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable(); 
            


            ds.Tables.Add(dt);
            return ds;
        }

        public MySqlConnection MakeConnection()
        {
            throw new NotImplementedException();
        }
    }
}
