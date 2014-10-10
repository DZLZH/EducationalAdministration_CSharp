using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace jwglxt
{
    class DBHelper
    {
        private static string constring = @"Data Source=.;Initial Catalog=jiaowu;Integrated Security=True;";
        public static SqlConnection con = new SqlConnection(constring);


    }

}
