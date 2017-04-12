namespace SIMS2
{
    partial class Staff_Form
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
            this.components = new System.ComponentModel.Container();
            this.cmb_SearchStudent = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new SIMS2.Database1DataSet();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.btn_SelectStu = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmb_SearchInstructor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_RegisterNewStudent = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_RegisterNewInstructor = new System.Windows.Forms.Button();
            this.studentTableAdapter = new SIMS2.Database1DataSetTableAdapters.studentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_SearchStudent
            // 
            this.cmb_SearchStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SearchStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SearchStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "studentId", true));
            this.cmb_SearchStudent.FormattingEnabled = true;
            this.cmb_SearchStudent.Location = new System.Drawing.Point(15, 40);
            this.cmb_SearchStudent.Name = "cmb_SearchStudent";
            this.cmb_SearchStudent.Size = new System.Drawing.Size(169, 21);
            this.cmb_SearchStudent.TabIndex = 35;
            this.cmb_SearchStudent.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchStudent_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.database1DataSet;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Select a Student";
            // 
            // btn_SelectStu
            // 
            this.btn_SelectStu.Location = new System.Drawing.Point(109, 67);
            this.btn_SelectStu.Name = "btn_SelectStu";
            this.btn_SelectStu.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectStu.TabIndex = 37;
            this.btn_SelectStu.Text = "Select";
            this.btn_SelectStu.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmb_SearchStudent);
            this.groupBox5.Controls.Add(this.btn_SelectStu);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(12, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "View Student Info";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmb_SearchInstructor);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(12, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "View Instructor Info";
            // 
            // cmb_SearchInstructor
            // 
            this.cmb_SearchInstructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SearchInstructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SearchInstructor.FormattingEnabled = true;
            this.cmb_SearchInstructor.Location = new System.Drawing.Point(16, 40);
            this.cmb_SearchInstructor.Name = "cmb_SearchInstructor";
            this.cmb_SearchInstructor.Size = new System.Drawing.Size(169, 21);
            this.cmb_SearchInstructor.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Select an Instructor";
            // 
            // btn_RegisterNewStudent
            // 
            this.btn_RegisterNewStudent.Location = new System.Drawing.Point(21, 19);
            this.btn_RegisterNewStudent.Name = "btn_RegisterNewStudent";
            this.btn_RegisterNewStudent.Size = new System.Drawing.Size(144, 23);
            this.btn_RegisterNewStudent.TabIndex = 39;
            this.btn_RegisterNewStudent.Text = "Register new Student";
            this.btn_RegisterNewStudent.UseVisualStyleBackColor = true;
            this.btn_RegisterNewStudent.Click += new System.EventHandler(this.btn_RegisterNewStudent_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_RegisterNewInstructor);
            this.groupBox7.Controls.Add(this.btn_RegisterNewStudent);
            this.groupBox7.Location = new System.Drawing.Point(12, 232);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "New Register";
            // 
            // btn_RegisterNewInstructor
            // 
            this.btn_RegisterNewInstructor.Location = new System.Drawing.Point(21, 53);
            this.btn_RegisterNewInstructor.Name = "btn_RegisterNewInstructor";
            this.btn_RegisterNewInstructor.Size = new System.Drawing.Size(144, 23);
            this.btn_RegisterNewInstructor.TabIndex = 40;
            this.btn_RegisterNewInstructor.Text = "Register new Instructor";
            this.btn_RegisterNewInstructor.UseVisualStyleBackColor = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // Staff_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 395);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "Staff_Form";
            this.Text = "Staff_Form";
            this.Load += new System.EventHandler(this.Staff_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_SearchStudent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_SelectStu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmb_SearchInstructor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_RegisterNewStudent;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_RegisterNewInstructor;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource1;
    }
}