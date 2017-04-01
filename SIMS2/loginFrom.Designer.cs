namespace SIMS2
{
    partial class loginFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_loginType = new System.Windows.Forms.ComboBox();
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(175, 191);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(99, 30);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(151, 20);
            this.tb_username.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(99, 69);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(151, 20);
            this.tb_password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LoginType";
            // 
            // cmb_loginType
            // 
            this.cmb_loginType.FormattingEnabled = true;
            this.cmb_loginType.Items.AddRange(new object[] {
            "Instructor",
            "Student",
            "Staff"});
            this.cmb_loginType.Location = new System.Drawing.Point(99, 111);
            this.cmb_loginType.Name = "cmb_loginType";
            this.cmb_loginType.Size = new System.Drawing.Size(120, 21);
            this.cmb_loginType.TabIndex = 6;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(319, 30);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(240, 150);
            this.dg.TabIndex = 9;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridtest_CellContentClick);
            // 
            // loginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 364);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.cmb_loginType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginFrom";
            this.Text = "loginFrom";
            this.Load += new System.EventHandler(this.loginFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_loginType;
        private System.Windows.Forms.DataGridView dg;
    }
}