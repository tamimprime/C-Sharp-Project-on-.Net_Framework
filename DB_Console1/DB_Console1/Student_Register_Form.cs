using Data_Access;
using Data_Access.Entities;
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
    public partial class Student_Register_Form : Form
    {
        public Student_Register_Form()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Open_Confirm_Click(object sender, EventArgs e)
        {
            var id = tb_id.Text;
            var name = tb_name.Text;
            var dept = tb_dept.Text;
            var section = tb_sec.Text;
            var cgpa = tb_cgpa.Text;
            var credit = tb_credit.Text;
            var username = tb_uname.Text;
            var password = tb_pass.Text;

            Student stu = new Student();
            stu.Id = id;
            stu.Name = name;
            stu.Dept = dept;
            stu.Section = section;
            stu.Cgpa = cgpa;
            stu.Credit = credit;
            stu.Username = username;
            stu.Password = password;

            Database db = new Database();
            bool r = db.Student.Insert(stu);
            if (r==true)
            {
                MessageBox.Show("Row Inserted.");
                tb_id.Text = "";
                tb_name.Text = "";
                tb_dept.Text = "";
                tb_sec.Text = "";
                tb_cgpa.Text = "";
                tb_credit.Text = "";
                tb_uname.Text = "";
                tb_pass.Text = "";
            }
            else
            {
                MessageBox.Show("Row Insert Error.");
                tb_id.Text = "";
                tb_name.Text = "";
                tb_dept.Text = "";
                tb_sec.Text = "";
                tb_cgpa.Text = "";
                tb_credit.Text = "";
                tb_uname.Text = "";
                tb_pass.Text = "";
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student_Login_Form().Show();
        }

    }
}
