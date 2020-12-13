using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class General
    {
        public static string TK = null;
        public static string SQL = null;
        public static string Name = null;
        public SqlConnection con = new SqlConnection(@"Data Source=" + SQL + ";Initial Catalog=QLSHOPQA;Integrated Security = True");
        public SqlConnection GetCon()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                return con;
            }
            catch (Exception err)
            {
                throw (err);
            }

        }
    }
}
