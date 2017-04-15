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

        public ViewStudentInfo()
        {
            InitializeComponent();
        }

        public ViewStudentInfo(int Student_id)
        {
            InitializeComponent();
            ViewStudentInfo_Load(Student_id);

        }

        private void ViewStudentInfo_Load(int Student_id)
        {
          // load the personal info
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from student where studentId ="+ Student_id, connection))
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


            // query for the student's Courses and add them to the datagridview Course_details
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from course c , Student_Course sc WHERE c.courseId =sc.courseId and sc.studentId =" + Student_id
                , connection))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                for(int i = 0;i<datatable.Rows.Count;i++)
                {
                        DataRow datarow = datatable.Rows[i];
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(GV_CoursesData);
                    
                    dgvRow.Cells[0].Value = datarow[0];
                    dgvRow.Cells[1].Value = datarow[1];
                    dgvRow.Cells[2].Value = datarow[2];
                    dgvRow.Cells[3].Value = datarow[3];
                    dgvRow.Cells[4].Value = datarow[6];


                    GV_CoursesData.Rows.Add(dgvRow);
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
    }
}
