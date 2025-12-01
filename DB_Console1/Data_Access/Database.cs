using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.Tables;
using System.Data.SqlClient;

namespace Data_Access
{
    public class Database
    {
        public Teachers Teachers { get; set; }
        public Students Student { get; set; }
        public object Teacher { get; set; }

        public Database()
        {
            /*string connStr = @"Server=DESKTOP-0L2RAUQ\SQLEXPRESS; Database=VARSITY_DB; Integrated Security= true";
            SqlConnection conn = new SqlConnection(connStr);
            Teachers = new Teachers(conn);*/

            Teachers = new Teachers ();
            Student = new Students();



            
        }

    }
}
