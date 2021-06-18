using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace University.Models.Database
{
    public class Departments
    {
        SqlConnection conn;

        public Departments(SqlConnection conn)
        {
            this.conn = conn;
        }

        public List<Department> GetAll()
        {
            List<Department> department = new List<Department>();
            string query = "select * from Departments";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Department s = new Department()
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                };
                department.Add(s);
            }
            conn.Close();
            return department;
        }

        public void Insert(Department s)
        {
            string query = String.Format($"Insert into Departments values ('{s.Name}')");
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}