using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Cau1.DAL
{
    public class DBConnection
    {
        public DBConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection coon = new SqlConnection();
            coon.ConnectionString = ("Data Source=DESKTOP-5KB08SC;Initial Catalog = HR; User Id = sa; Password = admin");
            return coon;
        }
    }
}
