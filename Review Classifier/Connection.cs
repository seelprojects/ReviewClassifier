using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Review_Classifier
{
    class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public Connection()
        {
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["databaseConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
    }
}
