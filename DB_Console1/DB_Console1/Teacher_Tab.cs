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
    public partial class Teacher_Tab : Form
    {
        public Teacher_Tab()
        {
            InitializeComponent();

            Database db = new Database();
            List<Teacher> data = db.Teachers.Get_All_Teachers();
            dgv3.DataSource = data;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
            string uname = tb_uname.Text;
            Database db = new Database();
            Teacher tea = db.Teachers.Search(uname);
            if (tea == null)
            {
                MessageBox.Show("TEacher not found.");
                tb_uname.Text = "";
                tb_id.Text = "";
                tb_name.Text = "";
                tb_dept.Text = "";
                tb_status.Text = "";
            }
            else
            {
                tb_uname.Text = tea.Username;
                tb_id.Text = tea.Id;
                tb_name.Text = tea.Name;
                tb_dept.Text = tea.Dept;
                tb_status.Text = tea.Status;

            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student_Login_Result().Show();
        }
    }
}
