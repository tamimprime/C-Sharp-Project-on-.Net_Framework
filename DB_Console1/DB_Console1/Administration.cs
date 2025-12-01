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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
            Database db = new Database();
            List<Student> data = db.Student.Get_All_Students();
            dgv_student.DataSource = data;

            Database db1 = new Database();
            List<Teacher> data1 = db1.Teachers.Get_All_Teachers();
            dgv_teacher.DataSource = data1;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
            string uname = tb_uname.Text;

            if (rb_teacher.Checked)
            {
                Database db1 = new Database();
                Teacher tea = db1.Teachers.Search(uname);
                if (tea == null)
                {
                    MessageBox.Show("Not found.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_dept.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                }
                else
                {
                    tb_name.Text = tea.Name;
                    tb_id.Text = tea.Id;
                    tb_dept.Text = tea.Dept;
                    tb_username.Text = tea.Username;
                    tb_cgpa.Text = "";
                    tb_section.Text = "";
                }
            }

            if (rb_student.Checked)
            {
                Database db = new Database();
                Student stu = db.Student.Search(uname);
                if (stu == null)
                {
                    MessageBox.Show("Not found.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_dept.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                }
                else
                {
                    tb_name.Text = stu.Name;
                    tb_id.Text = stu.Id;
                    tb_section.Text = stu.Section;
                    tb_username.Text = stu.Username;
                    tb_dept.Text = stu.Dept;
                    tb_cgpa.Text = stu.Cgpa;
                }
            }
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            string updated_name = tb_name.Text;
            string updated_id = tb_id.Text;
            string updated_section = tb_section.Text;
            string update_username = tb_username.Text;
            string update_dept = tb_dept.Text;
            string update_cgpa = tb_cgpa.Text;

            if (rb_teacher.Checked)
            {
                Teacher tea = new Teacher();
                tea.Username = tb_username.Text;
                tea.Name = tb_name.Text;
                tea.Id = tb_id.Text;
                tea.Dept = tb_dept.Text;

                Database db1 = new Database();
                bool r = db1.Teachers.Update(tea);
                if (r)
                {
                    dgv_teacher.DataSource = db1.Teachers.Get_All_Teachers();
                    MessageBox.Show("Updated.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_dept.Text = "";
                    tb_username.Text = "";
                    tb_section.Text = "";
                    tb_cgpa.Text = "";
                }
                else
                {
                    MessageBox.Show("Update Error.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                    tb_dept.Text = "";
                }
            }

            if (rb_student.Checked)
            {
                Student stu = new Student();
                stu.Username = tb_username.Text;
                stu.Name = tb_name.Text;
                stu.Id = tb_id.Text;
                stu.Section = tb_section.Text;
                stu.Dept = tb_dept.Text;
                stu.Cgpa = tb_cgpa.Text;

                Database db = new Database();
                bool rs = db.Student.Update(stu);
                if (rs)
                {
                    dgv_student.DataSource = db.Student.Get_All_Students();
                    MessageBox.Show("Updated.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_dept.Text = "";
                    tb_username.Text = "";
                    tb_section.Text = "";
                    tb_cgpa.Text = "";
                }
                else
                {
                    MessageBox.Show("Update Error.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                    tb_dept.Text = "";
                }
            }
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            string username1 = tb_uname.Text;

            if (rb_teacher.Checked)
            {
                Database db1 = new Database();
                bool r = db1.Teachers.Delete(username1);
                if (r)
                {
                    dgv_teacher.DataSource = db1.Teachers.Get_All_Teachers();
                    MessageBox.Show("Row Deleted.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                    tb_dept.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                    tb_dept.Text = "";
                }
            }

            if (rb_student.Checked)
            {
                Database db = new Database();
                bool rs = db.Student.Delete(username1);
                if (rs)
                {
                    dgv_student.DataSource = db.Student.Get_All_Students();
                    MessageBox.Show("Row Deleted.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                    tb_dept.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR.");
                    tb_uname.Text = "";
                    tb_name.Text = "";
                    tb_id.Text = "";
                    tb_section.Text = "";
                    tb_username.Text = "";
                    tb_cgpa.Text = "";
                    tb_dept.Text = "";
                }
            }
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new Login_result().Show();
        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_login_Form().Show();
        }
    }
}