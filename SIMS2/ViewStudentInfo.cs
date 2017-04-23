using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIMS2
{
    public partial class ViewStudentInfo : Form
    {
        SqlConnection connection;
        String connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
        String departmentId;
        String [] takenCourses;
        int Student_id;
        int Maxcredit = 20;
        public ViewStudentInfo()
        {
            InitializeComponent();
        }

        public ViewStudentInfo(int Student_id,String logintype)
        {
            InitializeComponent();
            this.Student_id = Student_id;
            ViewStudentInfo_Load();
            
        }

        private void ViewStudentInfo_Load()
        {

            // load the personal info
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from student where studentId =" + Student_id, connection))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                DataRow dataRow = datatable.Rows[0];
                lbl_name.Text = dataRow[1].ToString();
                lbl_StuID.Text = dataRow[0].ToString();
                lbl_Lname.Text = dataRow[2].ToString();
                lbl_birthday.Text = dataRow[4].ToString();
                lbl_gender.Text = dataRow[5].ToString();
                lbl_RegisterDate.Text = dataRow[6].ToString();
                lbl_Nationalty.Text = dataRow[7].ToString();
                lbl_NationalId.Text = dataRow[8].ToString();
                lbl_address.Text = dataRow[10].ToString();
                lbl_Email.Text = dataRow[11].ToString();
                lbl_PhoneNo.Text = dataRow[12].ToString();

            }
            // to retreive the department of the student
            try
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("select d.dname , d.deptid from student_dept sd , department d where sd.deptid=d.deptid and studentId =" + Student_id, connection))
                {

                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    DataRow dataRow = datatable.Rows[0];

                    lbl_Department.Text = dataRow[0].ToString();
                    departmentId = dataRow[1].ToString();
                    //MessageBox.Show(departmentId);

                }
            }
            catch (Exception)
            {
                departmentId = "4";
                lbl_Department.Text = "Software Engineering";
            }
            

            // query for the student's Courses and add them to the datagridview Course_details
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from course c , Student_Course sc WHERE c.courseId =sc.courseId and sc.studentId =" + Student_id
                , connection))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                takenCourses = new String[datatable.Rows.Count];

                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow datarow = datatable.Rows[i];
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    dgvRow.CreateCells(GV_CoursesData);
                    takenCourses[i] = datarow[0].ToString();
                    dgvRow.Cells[0].Value = datarow[0];
                    dgvRow.Cells[1].Value = datarow[1];
                    dgvRow.Cells[2].Value = datarow[2];
                    dgvRow.Cells[3].Value = datarow[3];
                    dgvRow.Cells[4].Value = datarow[6];

                    GV_CoursesData.Rows.Add(dgvRow);


                }

            }
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from course c , Student_Course sc WHERE c.courseId =sc.courseId and sc.studentId =" + Student_id
                , connection))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow datarow = datatable.Rows[i];
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    dgvRow.CreateCells(dgv_TakenCourse);

                    dgvRow.Cells[0].Value = datarow[0];
                    dgvRow.Cells[1].Value = datarow[1];
                    dgvRow.Cells[2].Value = datarow[2];
                    dgvRow.Cells[3].Value = datarow[3];
                    dgvRow.Cells[4].Value = datarow[6];

                    dgv_TakenCourse.Rows.Add(dgvRow);


                }
            }


            // to fill the offered courses
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from course c ,Dept_course dc where dc.courseid=c.courseid and dc.deptid =" + departmentId, connection))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow datarow = datatable.Rows[i];
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    dgvRow.CreateCells(dgv_AvailbleCourses);

                    dgvRow.Cells[0].Value = datarow[0];
                    dgvRow.Cells[1].Value = datarow[1];
                    dgvRow.Cells[2].Value = datarow[2];
                    dgvRow.Cells[3].Value = datarow[3];
                   // dgvRow.Cells[4].Value = datarow[6];

                    dgv_AvailbleCourses.Rows.Add(dgvRow);


                }
            }

            dgv_AvailbleCourses.ClearSelection();
            dgv_TakenCourse.ClearSelection();

        }
        private void Load_student_Courses()
        {
           // lbl_MaxCredit.Text = Maxcredit.ToString();
            
            dgv_TakenCourse.Rows.Clear();
            GV_CoursesData.Rows.Clear();
            // query for the student's Courses and add them to the datagridview Course_details
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from course c , Student_Course sc WHERE c.courseId =sc.courseId and sc.studentId =" + Student_id
                , connection))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                takenCourses = new String[datatable.Rows.Count];

                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow datarow = datatable.Rows[i];
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    dgvRow.CreateCells(GV_CoursesData);
                    takenCourses[i] = datarow[0].ToString();
                    dgvRow.Cells[0].Value = datarow[0];
                    dgvRow.Cells[1].Value = datarow[1];
                    dgvRow.Cells[2].Value = datarow[2];
                    dgvRow.Cells[3].Value = datarow[3];
                    dgvRow.Cells[4].Value = datarow[6];

                    GV_CoursesData.Rows.Add(dgvRow);


                }

            }
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from course c , Student_Course sc WHERE c.courseId =sc.courseId and sc.studentId =" + Student_id
                , connection))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow datarow = datatable.Rows[i];
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    dgvRow.CreateCells(dgv_TakenCourse);

                    dgvRow.Cells[0].Value = datarow[0];
                    dgvRow.Cells[1].Value = datarow[1];
                    dgvRow.Cells[2].Value = datarow[2];
                    dgvRow.Cells[3].Value = datarow[3];
                    dgvRow.Cells[4].Value = datarow[6];

                    dgv_TakenCourse.Rows.Add(dgvRow);


                }
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void ViewStudentInfo_Load(object sender, EventArgs e)
        {

        }

       

       

        private void dgv_TakenCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_AvailbleCourses.ClearSelection();
            
            
        }

        private void dgv_AvailbleCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dgv_TakenCourse.ClearSelection();
        }

        private void btn_take_Click_1(object sender, EventArgs e)
        {
            try
            {
                var code = dgv_AvailbleCourses.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(code);
                if (Array.IndexOf(takenCourses, code) != -1) MessageBox.Show("this course is already taken");
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string queryString = "INSERT into Student_Course  VALUES (@studentid,@courseid,@status,@grade)";

                        using (SqlCommand cmd_takecourse = new SqlCommand(queryString))
                        {
                            cmd_takecourse.Connection = con;
                            cmd_takecourse.Parameters.AddWithValue("@studentid", Student_id);
                            cmd_takecourse.Parameters.AddWithValue("@courseid", code);
                            cmd_takecourse.Parameters.AddWithValue("@status", "?");
                            cmd_takecourse.Parameters.AddWithValue("@grade", "?");
                            con.Open();
                            cmd_takecourse.ExecuteNonQuery();

                        }
                    }

                    Load_student_Courses();
                    MessageBox.Show("the course is taken successfully !!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("choose a course ");
            }
 
        }

        private void btn_Drop_Click_1(object sender, EventArgs e)
        {
            try
            {
                var code = dgv_TakenCourse.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(code);
                if (Array.IndexOf(takenCourses, code) != -1)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query_dropCourse = "delete from Student_Course  where studentid= @studentid and courseid= @courseid";

                        using (SqlCommand cmd = new SqlCommand(query_dropCourse))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@studentid", Student_id);
                            cmd.Parameters.AddWithValue("@courseid", code);
                            con.Open();
                            cmd.ExecuteNonQuery();

                        }
                    }

                    Load_student_Courses();
                    MessageBox.Show("the course is dropped !!");
                }
                else MessageBox.Show("please select a course to drop");
            }
            catch (Exception)
            {

                MessageBox.Show("select a course to drop");
            }
            
            

        }

        private void btn_chagneConfirmation_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from student where studentId =" + Student_id, connection))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                DataRow dataRow = datatable.Rows[0];
                if (textBox1.Text == dataRow[13].ToString())
                {
                    //change the password 
                    if (textBox2.Text == textBox3.Text)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            string query_updatePass = "UPDATE student SET password = @newpassword WHERE studentid= @studentid ;";

                            using (SqlCommand cmd = new SqlCommand(query_updatePass))
                            {
                                cmd.Connection = con;
                                string newpassword = textBox2.Text;
                                cmd.Parameters.AddWithValue("@studentid", Student_id);
                                cmd.Parameters.AddWithValue("@newpassword", newpassword);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("passwword updated succesfully");

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("passwords dont match");
                    }
                }
                else
                {
                    //password is incorrect
                    MessageBox.Show("incorrect password,please try again");

                }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show( "Please Confirm the Deletion !!", "Confirm", MessageBoxButtons.YesNo);
               
            if (dr.ToString()=="Yes")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query_updatePass = "delete from student  WHERE studentid= @studentid ;";

                    using (SqlCommand cmd = new SqlCommand(query_updatePass))
                    {
                        cmd.Connection = con;
                        string newpassword = textBox2.Text;
                        cmd.Parameters.AddWithValue("@studentid", Student_id);

                        con.Open();
                        cmd.ExecuteNonQuery();
      
                    }
                }
                this.Dispose();
            }
            
        }
    }
}
