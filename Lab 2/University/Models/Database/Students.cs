using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace University.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student s)
        {
            string query = String.Format($"Insert into Students values ('{s.Name}','{s.DOB}',{s.Credit},{s.CGPA},{s.Dept_id})");
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }

        public List<Student> GetAllWithDeptName()
        {
            List<Student> students = new List<Student>();
            string query = "SELECT Students.*, Departments.Name as Dept_name FROM Students, Departments Where Students.Dept_id = Departments.ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                    Dept_name = reader.GetString(reader.GetOrdinal("Dept_name")),
                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }

        public Student Get(int id)
        {
            Student s = null;
            string query = $"select * from Students Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                };
            }
            conn.Close();
            return s;
        }
        public void Update(Student s)
        {
            string query = $"Update Students Set Name='{s.Name}',DOB='{s.DOB}', Credit={s.Credit}, CGPA={s.CGPA}, Dept_id={s.Dept_id} where Id={s.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            string query = $"DELETE FROM Students WHERE Id = {id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}