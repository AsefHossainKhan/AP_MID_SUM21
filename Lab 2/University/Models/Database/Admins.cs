using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace University.Models.Database
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Admin Get(int id)
        {
            Admin a = null;
            string query = $"select * from Admins Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                a = new Admin()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    Password = reader.GetString(reader.GetOrdinal("Password")),
                };
            }
            conn.Close();
            return a;
        }

        public string Validate(string Username)
        {
            string query = $"SELECT * FROM Admins WHERE Username = '{Username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Admin a = null;
            while (reader.Read())
            {
                a = new Admin()
                {
                    Password = reader.GetString(reader.GetOrdinal("Password")),
                };
            }
            if (a != null)
            {
                return a.Password;
            }
            else
            {
                return null;
            }
        }

        public List<Admin> GetAll()
        {
            List<Admin> admins = new List<Admin>();
            string query = "select * from Admins";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Admin a = new Admin()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    Password = reader.GetString(reader.GetOrdinal("Password")),
                };
                admins.Add(a);
            }
            conn.Close();
            return admins;
        }
    }
}