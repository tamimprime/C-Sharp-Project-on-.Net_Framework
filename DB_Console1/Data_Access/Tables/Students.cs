using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data_Access.Entities;

namespace Data_Access.Tables
{
    public class Students
    {
        SqlConnection conn;

        public Students(/*SqlConnection conn*/)
        {
            //this.conn = conn;
            string connStr = @"Server=DESKTOP-0L2RAUQ\SQLEXPRESS; Database=VARSITY_DB; Integrated Security= true";
            conn = new SqlConnection(connStr);
        }

        public List<Student> Get_All_Students()
        {
            string query = "select * from Students";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Student> data = new List<Student>();

            while (reader.Read())
            {
                Student stu = new Student();

                stu.Id = reader.GetString(reader.GetOrdinal("Id"));
                stu.Name = reader.GetString(reader.GetOrdinal("Name"));
                stu.Dept = reader.GetString(reader.GetOrdinal("Dept"));
                stu.Section = reader.GetString(reader.GetOrdinal("Section"));
                stu.Cgpa = reader.GetString(reader.GetOrdinal("Cgpa"));
                stu.Credit = reader.GetString(reader.GetOrdinal("Credit"));
                stu.Username = reader.GetString(reader.GetOrdinal("Username"));
                //stu.Password = reader.GetString(reader.GetOrdinal("Password"));
                data.Add(stu);
            }
            conn.Close();
            return data;
        }

        public bool Insert(Student stu)
        {
            string query = string.Format("insert into Students values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", stu.Id, stu.Name, stu.Dept, stu.Section, stu.Cgpa, stu.Credit, stu.Username, stu.Password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Student Search(string uname)
        {
            string query = string.Format("select * from Students where Username= '{0}'", uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student stu = null;
            while (reader.Read())
            {
                stu = new Student();
                stu.Id = reader.GetString(reader.GetOrdinal("Id"));
                stu.Name = reader.GetString(reader.GetOrdinal("Name"));
                stu.Dept = reader.GetString(reader.GetOrdinal("Dept"));
                stu.Section = reader.GetString(reader.GetOrdinal("Section"));
                stu.Cgpa = reader.GetString(reader.GetOrdinal("Cgpa"));
                stu.Credit = reader.GetString(reader.GetOrdinal("Credit"));
                stu.Username = reader.GetString(reader.GetOrdinal("Username"));
                //stu.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return stu;
        }

        public bool Update(Student stu)
        {
            string query = string.Format("Update Students set Name= '{0}', Id= '{1}', Section='{2}' where Username= '{3}'", stu.Name, stu.Id, stu.Section, stu.Username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool Delete(string username)
        {
            string query = string.Format("delete from Students where Username='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                return true;
            }
            return false;
        }

        public bool Check_login(string username, string password)
        {
            string query = string.Format("select Name from Students where Username='{0}' and Password='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;

        }
    }
}
