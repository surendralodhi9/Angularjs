using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace LoginAngular
{
    public class DatabaseClass
    {


        SqlConnection con = new SqlConnection("Path///");
        public int userlogin(Users us)
        {

            string sql = "select *from Users where username=? and password=?";
            SqlCommand comd = new SqlCommand(sql, con);
            SqlDataReader reader = comd.ExecuteReader();
            if(reader.Read())
            return 1;
            return 0;
        }
    }
}