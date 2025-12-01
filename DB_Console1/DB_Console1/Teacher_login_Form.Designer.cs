
namespace DB_Console1
{
    partial class Teacher_login_Form
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
            this.login = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.pocreed = new System.Windows.Forms.Label();
            this.Open_Student_Login_form = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(234, 102);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(173, 55);
            this.login.TabIndex = 0;
            this.login.Text = "LOGIN";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(64, 249);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(191, 33);
            this.pass.TabIndex = 1;
            this.pass.Text = "PASSWORD:";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(64, 192);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(186, 33);
            this.uname.TabIndex = 2;
            this.uname.Text = "USERNAME:";
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.Location = new System.Drawing.Point(266, 190);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(306, 38);
            this.tb_uname.TabIndex = 3;
            // 
            // tb_pass
            // 
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(266, 249);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(306, 38);
            this.tb_pass.TabIndex = 4;
            this.tb_pass.UseSystemPasswordChar = true;
            this.tb_pass.UseWaitCursor = true;
            // 
            // pocreed
            // 
            this.pocreed.AutoSize = true;
            this.pocreed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pocreed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pocreed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pocreed.Location = new System.Drawing.Point(232, 313);
            this.pocreed.Name = "pocreed";
            this.pocreed.Size = new System.Drawing.Size(175, 39);
            this.pocreed.TabIndex = 5;
            this.pocreed.Text = "PROCEED";
            this.pocreed.Click += new System.EventHandler(this.Teacher_Login_Click);
            // 
            // Open_Student_Login_form
            // 
            this.Open_Student_Login_form.AutoSize = true;
            this.Open_Student_Login_form.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Open_Student_Login_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_Student_Login_form.Location = new System.Drawing.Point(168, 375);
            this.Open_Student_Login_form.Name = "Open_Student_Login_form";
            this.Open_Student_Login_form.Size = new System.Drawing.Size(296, 37);
            this.Open_Student_Login_form.TabIndex = 6;
            this.Open_Student_Login_form.Text = "For Student\'s Login";
            this.Open_Student_Login_form.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Open_Student_Login_form.Click += new System.EventHandler(this.Open_Student_Login_Form);
            // 
            // Teacher_login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(637, 531);
            this.Controls.Add(this.Open_Student_Login_form);
            this.Controls.Add(this.pocreed);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Name = "Teacher_login_Form";
            this.Text = "Teacher_login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label pocreed;
        private System.Windows.Forms.Label Open_Student_Login_form;
        private System.Windows.Forms.TextBox tb_pass;
    }
}