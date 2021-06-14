using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace University.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-F27PM3S;Database=UMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);

        }
    }
}