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
    public partial class Login_result : Form
    {
        public Login_result()
        {
            InitializeComponent();

            Database db = new Database();
            List<Student> data = db.Student.Get_All_Students();
            dgv1.DataSource = data;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Search_user(object sender, EventArgs e)
        {
            string uname = tb_uname.Text;
            Database db = new Database();
            Student stu = db.Student.Search(uname);
            if (stu == null)
            {
                MessageBox.Show("Student not found.");
                tb_uname.Text = "";
                tb_name.Text = "";
                tb_id.Text = "";
                tb_section.Text = "";
            }
            else 
            {
                tb_name.Text = stu.Name;
                tb_id.Text = stu.Id;
                tb_section.Text = stu.Section;

            }
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            string updated_name = tb_name.Text;
            string updated_id = tb_id.Text;
            string updated_section = tb_section.Text;

            Student stu = new Student();
            stu.Username = tb_uname.Text;
            stu.Name = tb_name.Text;
            stu.Id = tb_id.Text;
            stu.Section = tb_section.Text;

            Database db = new Database();
            bool rs = db.Student.Update(stu);
            if(rs)
            {
                MessageBox.Show("Updated.");
                tb_uname.Text = "";
                tb_name.Text = "";
                tb_id.Text = "";
                tb_section.Text = "";
            }
            else
            {
                MessageBox.Show("Update Error.");
                tb_uname.Text = "";
                tb_name.Text = "";
                tb_id.Text = "";
                tb_section.Text = "";
            }
        }


        private void Delete_Clicked(object sender, EventArgs e)
        {
            string username = tb_uname.Text;
            Database db = new Database();
            bool rs = db.Student.Delete(username);
            if (rs)
            {
                dgv1.DataSource = db.Student.Get_All_Students();
                MessageBox.Show("Row Deleted.");
                tb_uname.Text = "";
                tb_name.Text = "";
                tb_id.Text = "";
                tb_section.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR.");
                tb_uname.Text = "";
                tb_name.Text = "";
                tb_id.Text = "";
                tb_section.Text = "";
            }
        }

        private void Refresh_Ckick(object sender, EventArgs e)
        {
            this.Hide();
            new Login_result().Show();
        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_login_Form().Show();

        }

        private void Administration_clicked(object sender, EventArgs e)
        {
            this.Hide();
            new Administration().Show();
        }
    }
}
