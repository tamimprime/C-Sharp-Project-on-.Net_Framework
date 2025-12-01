
namespace DB_Console1
{
    partial class Student_Login_Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.bt_teachers = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_section = new System.Windows.Forms.TextBox();
            this.tb_cgpa = new System.Windows.Forms.TextBox();
            this.tb_credit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(12, 12);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(754, 355);
            this.dgv2.TabIndex = 0;
            // 
            // bt_teachers
            // 
            this.bt_teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_teachers.Location = new System.Drawing.Point(361, 488);
            this.bt_teachers.Name = "bt_teachers";
            this.bt_teachers.Size = new System.Drawing.Size(284, 42);
            this.bt_teachers.TabIndex = 1;
            this.bt_teachers.Text = "Teacher\'s Information";
            this.bt_teachers.UseVisualStyleBackColor = true;
            this.bt_teachers.Click += new System.EventHandler(this.Open_Teacher_Tab);
            // 
            // bt_logout
            // 
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Location = new System.Drawing.Point(51, 488);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(102, 42);
            this.bt_logout.TabIndex = 3;
            this.bt_logout.Text = "LogOut";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.Logout_Clicked);
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(51, 430);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 17;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.Student_Search_Clicked);
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_uname.Location = new System.Drawing.Point(12, 398);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(192, 26);
            this.tb_uname.TabIndex = 15;
            this.tb_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(9, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(763, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "=================================================================================" +
    "=============================================";
            // 
            // tb_dept
            // 
            this.tb_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_dept.Location = new System.Drawing.Point(409, 398);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(86, 26);
            this.tb_dept.TabIndex = 20;
            this.tb_dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_name.Location = new System.Drawing.Point(320, 398);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(83, 26);
            this.tb_name.TabIndex = 21;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_id.Location = new System.Drawing.Point(230, 398);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(84, 26);
            this.tb_id.TabIndex = 22;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_section
            // 
            this.tb_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_section.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_section.Location = new System.Drawing.Point(501, 398);
            this.tb_section.Name = "tb_section";
            this.tb_section.Size = new System.Drawing.Size(84, 26);
            this.tb_section.TabIndex = 25;
            this.tb_section.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cgpa
            // 
            this.tb_cgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cgpa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_cgpa.Location = new System.Drawing.Point(591, 398);
            this.tb_cgpa.Name = "tb_cgpa";
            this.tb_cgpa.Size = new System.Drawing.Size(83, 26);
            this.tb_cgpa.TabIndex = 24;
            this.tb_cgpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_credit
            // 
            this.tb_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_credit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_credit.Location = new System.Drawing.Point(680, 398);
            this.tb_credit.Name = "tb_credit";
            this.tb_credit.Size = new System.Drawing.Size(86, 26);
            this.tb_credit.TabIndex = 23;
            this.tb_credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(457, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "(Click below for)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(695, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = " Credit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(610, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cgpa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(512, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(433, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Dept";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(338, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(263, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(61, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Username";
            // 
            // Student_Login_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(778, 537);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_section);
            this.Controls.Add(this.tb_cgpa);
            this.Controls.Add(this.tb_credit);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_dept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_teachers);
            this.Controls.Add(this.dgv2);
            this.Name = "Student_Login_Result";
            this.Text = "Student_Login_Result";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button bt_teachers;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dept;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_section;
        private System.Windows.Forms.TextBox tb_cgpa;
        private System.Windows.Forms.TextBox tb_credit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}