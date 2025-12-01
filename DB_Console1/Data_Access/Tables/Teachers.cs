using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data_Access.Entities;

namespace Data_Access.Tables
{
    public class Teachers
    {
        SqlConnection conn;

        public Teachers(/*SqlConnection conn*/)
        {
            //this.conn = conn;
            string connStr = @"Server=DESKTOP-0L2RAUQ\SQLEXPRESS; Database=VARSITY_DB; Integrated Security= true";
            conn = new SqlConnection(connStr);
        }

        public List<Teacher> Get_All_Teachers()
        {
            string query = "select * from Teachers";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Teacher> data = new List<Teacher>();

            while (reader.Read())
            {
                Teacher tea = new Teacher();

                tea.Id = reader.GetString(reader.GetOrdinal("Id"));
                tea.Name = reader.GetString(reader.GetOrdinal("Name"));
                tea.Dept = reader.GetString(reader.GetOrdinal("Dept"));
                tea.Status = reader.GetString(reader.GetOrdinal("Status"));
                tea.Username = reader.GetString(reader.GetOrdinal("Username"));
                //tea.Password = reader.GetString(reader.GetOrdinal("Password"));
                data.Add(tea);
            }

            conn.Close();
            return data;
        }
        
        public bool Insert(Teacher tea)
        {
            string query = string.Format("insert into Teachers values ('{0}','{1}','{2}','{3}','{4}','{5}')", tea.Id, tea.Name, tea.Dept, tea.Status, tea.Username, tea.Password);
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

        public Teacher Search(string uname)
        {
            string query = string.Format("select * from Teachers where Username= '{0}'" ,uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Teacher tea = null;
            while (reader.Read())
            {
                tea = new Teacher();
                tea.Id = reader.GetString(reader.GetOrdinal("Id"));
                tea.Name = reader.GetString(reader.GetOrdinal("Name"));
                tea.Dept = reader.GetString(reader.GetOrdinal("Dept"));
                tea.Status = reader.GetString(reader.GetOrdinal("Status"));
                tea.Username = reader.GetString(reader.GetOrdinal("Username"));
                //tea.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return tea;
        }

        public bool Update(Teacher tea)
        {
            string query = string.Format("Update Teachers set Name= '{0}', Id= '{1}', Dept='{2}' where Username= '{3}'", tea.Name, tea.Id, tea.Dept, tea.Username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool Delete(string username)
        {
            string query = string.Format("delete from Teachers where Username='{0}'", username);
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
            string query = string.Format("select Name from Teachers where Username='{0}' and Password='{1}'", username, password);
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

