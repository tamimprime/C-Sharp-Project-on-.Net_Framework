
namespace DB_Console1
{
    partial class Login_result
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_section = new System.Windows.Forms.TextBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_administration = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(340, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(633, 403);
            this.dgv1.TabIndex = 0;
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_uname.Location = new System.Drawing.Point(12, 22);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(314, 26);
            this.tb_uname.TabIndex = 1;
            this.tb_uname.Text = "Type Username Here";
            this.tb_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(125, 54);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 3;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.Search_user);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_name.Location = new System.Drawing.Point(12, 110);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(314, 26);
            this.tb_name.TabIndex = 4;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_id.Location = new System.Drawing.Point(12, 154);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(314, 26);
            this.tb_id.TabIndex = 5;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_section
            // 
            this.tb_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_section.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_section.Location = new System.Drawing.Point(12, 200);
            this.tb_section.Name = "tb_section";
            this.tb_section.Size = new System.Drawing.Size(314, 26);
            this.tb_section.TabIndex = 6;
            this.tb_section.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Aqua;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Location = new System.Drawing.Point(36, 232);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(102, 23);
            this.bt_update.TabIndex = 7;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.Update_Clicked);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 8;
            this.name.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Section:";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.Location = new System.Drawing.Point(36, 392);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(102, 23);
            this.bt_refresh.TabIndex = 11;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.Refresh_Ckick);
            // 
            // bt_logout
            // 
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Location = new System.Drawing.Point(202, 392);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(102, 23);
            this.bt_logout.TabIndex = 12;
            this.bt_logout.Text = "LogOut";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.Logout_Clicked);
            // 
            // bt_administration
            // 
            this.bt_administration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_administration.Location = new System.Drawing.Point(36, 307);
            this.bt_administration.Name = "bt_administration";
            this.bt_administration.Size = new System.Drawing.Size(268, 35);
            this.bt_administration.TabIndex = 13;
            this.bt_administration.Text = "Administration";
            this.bt_administration.UseVisualStyleBackColor = true;
            this.bt_administration.Click += new System.EventHandler(this.Administration_clicked);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.LightCoral;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(202, 232);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(102, 23);
            this.bt_delete.TabIndex = 14;
            this.bt_delete.Text = "DELETE";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.Delete_Clicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-------------------------";
            // 
            // Login_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(982, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_administration);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.tb_section);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.dgv1);
            this.Name = "Login_result";
            this.Text = "Login_result";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_section;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_administration;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}