using Data_Access;
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
    public partial class Student_Login_Form : Form
    {
        public Student_Login_Form()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }


        private void Student_Login_click(object sender, EventArgs e)
        {
            string username = tb_uname.Text;
            string password = tb_pass.Text;
            Database db = new Database();
            bool rs = db.Student.Check_login(username, password);
            if (rs == true)
            {
                this.Hide();
                new Student_Login_Result().Show();
            }

            else
            {
                _ = MessageBox.Show("Invalid Username or Password");
                tb_uname.Text = "";
                tb_pass.Text = "";
            }
        }

        private void Open_Student_Registration_Form(object sender, EventArgs e)
        {
            this.Hide();
            new Student_Register_Form().Show();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_login_Form().Show();
        }
    }
}
