
namespace DB_Console1
{
    partial class Administration
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
            this.dgv_teacher = new System.Windows.Forms.DataGridView();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_cgpa = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_section = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.rb_teacher = new System.Windows.Forms.RadioButton();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_teacher
            // 
            this.dgv_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teacher.Location = new System.Drawing.Point(12, 12);
            this.dgv_teacher.Name = "dgv_teacher";
            this.dgv_teacher.Size = new System.Drawing.Size(403, 253);
            this.dgv_teacher.TabIndex = 1;
            // 
            // dgv_student
            // 
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(421, 12);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.Size = new System.Drawing.Size(383, 253);
            this.dgv_student.TabIndex = 2;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.LightCoral;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(212, 45);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(102, 23);
            this.bt_delete.TabIndex = 26;
            this.bt_delete.Text = "DELETE";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.Delete_Clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Dept:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(59, 393);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 23;
            this.name.Text = "Name:";
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Aqua;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Location = new System.Drawing.Point(0, 45);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(102, 23);
            this.bt_update.TabIndex = 22;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.Update_Clicked);
            // 
            // tb_dept
            // 
            this.tb_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_dept.Location = new System.Drawing.Point(62, 499);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(314, 26);
            this.tb_dept.TabIndex = 21;
            this.tb_dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_id.Location = new System.Drawing.Point(62, 454);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(314, 26);
            this.tb_id.TabIndex = 20;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_name.Location = new System.Drawing.Point(59, 410);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(317, 26);
            this.tb_name.TabIndex = 19;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(109, 19);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 18;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.Search_Clicked);
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_uname.Location = new System.Drawing.Point(252, 271);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(314, 26);
            this.tb_uname.TabIndex = 17;
            this.tb_uname.Text = "Type Username Here";
            this.tb_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cgpa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Section:";
            // 
            // tb_cgpa
            // 
            this.tb_cgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cgpa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_cgpa.Location = new System.Drawing.Point(441, 499);
            this.tb_cgpa.Name = "tb_cgpa";
            this.tb_cgpa.Size = new System.Drawing.Size(314, 26);
            this.tb_cgpa.TabIndex = 31;
            this.tb_cgpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_username.Location = new System.Drawing.Point(441, 454);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(314, 26);
            this.tb_username.TabIndex = 30;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_section
            // 
            this.tb_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_section.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_section.Location = new System.Drawing.Point(441, 410);
            this.tb_section.Name = "tb_section";
            this.tb_section.Size = new System.Drawing.Size(314, 26);
            this.tb_section.TabIndex = 29;
            this.tb_section.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(21, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "=================================================================================" +
    "=============================================";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(21, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(763, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "=================================================================================" +
    "=============================================";
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(252, 552);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(102, 23);
            this.bt_back.TabIndex = 37;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.Back_Clicked);
            // 
            // bt_logout
            // 
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Location = new System.Drawing.Point(464, 552);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(102, 23);
            this.bt_logout.TabIndex = 38;
            this.bt_logout.Text = "LogOut";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.Logout_Clicked);
            // 
            // rb_teacher
            // 
            this.rb_teacher.AutoSize = true;
            this.rb_teacher.Location = new System.Drawing.Point(0, 22);
            this.rb_teacher.Name = "rb_teacher";
            this.rb_teacher.Size = new System.Drawing.Size(65, 17);
            this.rb_teacher.TabIndex = 39;
            this.rb_teacher.TabStop = true;
            this.rb_teacher.Text = "Teacher";
            this.rb_teacher.UseVisualStyleBackColor = true;
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Location = new System.Drawing.Point(246, 22);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(62, 17);
            this.rb_student.TabIndex = 40;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "Student";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rb_teacher);
            this.gb1.Controls.Add(this.rb_student);
            this.gb1.Controls.Add(this.bt_search);
            this.gb1.Controls.Add(this.bt_update);
            this.gb1.Controls.Add(this.bt_delete);
            this.gb1.Location = new System.Drawing.Point(252, 303);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(314, 74);
            this.gb1.TabIndex = 41;
            this.gb1.TabStop = false;
            this.gb1.Text = "Choose an Option to Proceed..";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 594);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_cgpa);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_section);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.tb_dept);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.dgv_teacher);
            this.Name = "Administration";
            this.Text = "Administration_Login_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_teacher;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox tb_dept;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_cgpa;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.RadioButton rb_teacher;
        private System.Windows.Forms.RadioButton rb_student;
        private System.Windows.Forms.GroupBox gb1;
    }
}