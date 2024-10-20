using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace FitForgeGym
{
    internal class Connectionstring
    {
        public SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-EOPDPD2\SQLEXPRESS;Initial Catalog=Fit_Forge;Integrated Security=True;Encrypt=False";
            return con;
        }

    }
}