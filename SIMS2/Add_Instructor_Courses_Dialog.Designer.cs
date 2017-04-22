namespace SIMS2
{
    partial class Add_Instructor_Courses_Dialog
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.lv_giverncourses = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(251, 279);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // lv_giverncourses
            // 
            this.lv_giverncourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Course});
            this.lv_giverncourses.FullRowSelect = true;
            this.lv_giverncourses.GridLines = true;
            this.lv_giverncourses.Location = new System.Drawing.Point(1, 24);
            this.lv_giverncourses.Name = "lv_giverncourses";
            this.lv_giverncourses.Size = new System.Drawing.Size(325, 249);
            this.lv_giverncourses.TabIndex = 112;
            this.lv_giverncourses.UseCompatibleStateImageBehavior = false;
            this.lv_giverncourses.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 75;
            // 
            // Course
            // 
            this.Course.Text = "Course";
            this.Course.Width = 250;
            // 
            // Add_Instructor_Courses_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 304);
            this.Controls.Add(this.lv_giverncourses);
            this.Controls.Add(this.btn_Add);
            this.Name = "Add_Instructor_Courses_Dialog";
            this.Text = "Add Course";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListView lv_giverncourses;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Course;
    }
}