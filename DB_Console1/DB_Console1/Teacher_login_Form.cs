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
    public partial class Teacher_login_Form : Form
    {
        public Teacher_login_Form()
        {
            InitializeComponent();
            //for data show
            //Database db = new Database();
            //List<Student> data = db.Students.Get_All_Students();
            //dgv1.DataSource = data;

            //List<string> data = new List<string>();
            //dgv1.DataSource
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        
        private void Teacher_Login_Click(object sender, EventArgs e)
        {
            string username = tb_uname.Text;
            string password = tb_pass.Text;
            Database db = new Database();
            bool rs = db.Teachers.Check_login(username, password);
            if (rs == true)
            {
                this.Hide();
                new Login_result().Show();
            }

            else
            {
                _ = MessageBox.Show("Invalid Username or Password");
                tb_uname.Text = "";
                tb_pass.Text = "";
            }

        }

        private void Open_Student_Login_Form(object sender, EventArgs e)
        {
            this.Hide();
            new Student_Login_Form().Show();
        }
    }
}
