using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogManagement
{
    class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        public void connection()
        {

            con = new SqlConnection(@"Data Source=.;Initial Catalog=CallManagement;Integrated Security=True");
            con.Open();
        }

        public void dataSend(string SQL)
        {
            try
            {
                connection();
                cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                pkk = "";

            }
            catch (Exception)
            {
                pkk = "Please Check Your Data";

            }
            con.Close();
        }
        public void dataGet(string SQL)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(SQL, con);
            }
            catch (Exception)
            {


            }
        }
    }
}
