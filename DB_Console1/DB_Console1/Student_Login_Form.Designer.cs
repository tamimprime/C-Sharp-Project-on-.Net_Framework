
namespace DB_Console1
{
    partial class Student_Login_Form
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
            this.bt_registration = new System.Windows.Forms.Button();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.slogin = new System.Windows.Forms.Label();
            this.messge = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_registration
            // 
            this.bt_registration.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registration.Location = new System.Drawing.Point(172, 306);
            this.bt_registration.Name = "bt_registration";
            this.bt_registration.Size = new System.Drawing.Size(233, 53);
            this.bt_registration.TabIndex = 20;
            this.bt_registration.Text = "Registration";
            this.bt_registration.UseVisualStyleBackColor = true;
            this.bt_registration.Click += new System.EventHandler(this.Open_Student_Registration_Form);
            // 
            // bt_proceed
            // 
            this.bt_proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proceed.Location = new System.Drawing.Point(224, 206);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(134, 53);
            this.bt_proceed.TabIndex = 19;
            this.bt_proceed.Text = "PROCEED";
            this.bt_proceed.UseVisualStyleBackColor = true;
            this.bt_proceed.Click += new System.EventHandler(this.Student_Login_click);
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(238, 156);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(248, 29);
            this.tb_pass.TabIndex = 18;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.Location = new System.Drawing.Point(238, 121);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(248, 29);
            this.tb_uname.TabIndex = 17;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(66, 155);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(157, 29);
            this.pass.TabIndex = 16;
            this.pass.Text = "PASSWORD:";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(69, 120);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(154, 29);
            this.uname.TabIndex = 15;
            this.uname.Text = "USERNAME:";
            // 
            // slogin
            // 
            this.slogin.AutoSize = true;
            this.slogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.slogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogin.Location = new System.Drawing.Point(194, 20);
            this.slogin.Name = "slogin";
            this.slogin.Size = new System.Drawing.Size(180, 78);
            this.slogin.TabIndex = 14;
            this.slogin.Text = "STUDENT\r\nLOGIN";
            this.slogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // messge
            // 
            this.messge.AutoSize = true;
            this.messge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messge.ForeColor = System.Drawing.SystemColors.GrayText;
            this.messge.Location = new System.Drawing.Point(185, 285);
            this.messge.Name = "messge";
            this.messge.Size = new System.Drawing.Size(199, 18);
            this.messge.TabIndex = 21;
            this.messge.Text = "For Registration Click Bellow";
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(233, 365);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(113, 31);
            this.bt_back.TabIndex = 22;
            this.bt_back.Text = "Go back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.Go_Back_Click);
            // 
            // Student_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 409);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.messge);
            this.Controls.Add(this.bt_registration);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.slogin);
            this.Name = "Student_Login_Form";
            this.Text = "Student_Register_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_registration;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label slogin;
        private System.Windows.Forms.Label messge;
        private System.Windows.Forms.Button bt_back;
    }
}