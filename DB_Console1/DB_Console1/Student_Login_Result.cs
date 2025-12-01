using Data_Access;
using Data_Access.Entities;
using Data_Access.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Console1
{
    public partial class Student_Login_Result : Form
    {
        public Student_Login_Result()
        {
            InitializeComponent();

            Database db = new Database();
            List<Student> data = db.Student.Get_All_Students();
            dgv2.DataSource = data;

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Student_Search_Clicked(object sender, EventArgs e)
        {
            string uname = tb_uname.Text;
            Database db = new Database();
            Student stu = db.Student.Search(uname);
            if (stu == null)
            {
                MessageBox.Show("Student not found.");
                tb_uname.Text = "";
                tb_id.Text = "";
                tb_name.Text = "";
                tb_dept.Text = "";
                tb_section.Text = "";
                tb_credit.Text = "";
                tb_cgpa.Text = "";
            }
            else
            {
                tb_uname.Text = stu.Username;
                tb_id.Text = stu.Id;
                tb_name.Text = stu.Name;
                tb_dept.Text = stu.Dept;
                tb_section.Text = stu.Section;
                tb_credit.Text = stu.Credit;
                tb_cgpa.Text = stu.Cgpa;

            }
        }

        private void Open_Teacher_Tab(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_Tab().Show();
        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new Student_Login_Form().Show();
        }
    }
}
