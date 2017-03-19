namespace SIMS2
{
    partial class Instructor_Interface
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
            this.courseslist = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_filter = new System.Windows.Forms.Button();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentslist = new System.Windows.Forms.ListBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseslist
            // 
            this.courseslist.FormattingEnabled = true;
            this.courseslist.Location = new System.Drawing.Point(6, 3);
            this.courseslist.Name = "courseslist";
            this.courseslist.Size = new System.Drawing.Size(189, 95);
            this.courseslist.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_filter);
            this.tabPage2.Controls.Add(this.textBox_lastname);
            this.tabPage2.Controls.Add(this.textBox_firstname);
            this.tabPage2.Controls.Add(this.textBox_id);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.studentslist);
            this.tabPage2.Controls.Add(this.btn_view);
            this.tabPage2.Controls.Add(this.courseslist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "course managment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(10, 222);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(161, 23);
            this.btn_filter.TabIndex = 9;
            this.btn_filter.Text = "filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(71, 184);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastname.TabIndex = 8;
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(71, 150);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstname.TabIndex = 7;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(71, 117);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // studentslist
            // 
            this.studentslist.FormattingEnabled = true;
            this.studentslist.Location = new System.Drawing.Point(201, 3);
            this.studentslist.Name = "studentslist";
            this.studentslist.Size = new System.Drawing.Size(348, 290);
            this.studentslist.TabIndex = 2;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(10, 260);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(161, 23);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "view student info";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 332);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Instructor_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "Instructor_Interface";
            this.Text = "Instructor_Interface";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox courseslist;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox studentslist;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}