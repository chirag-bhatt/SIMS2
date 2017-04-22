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
    public partial class ViewInstructorInfo : Form
    {
        SqlConnection connection;
        String connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
        int instructor_id;
        String[] givenCourses;

        public ViewInstructorInfo()
        {
            InitializeComponent();
        }

        public ViewInstructorInfo(int id )
        {
            this.instructor_id = id;
            InitializeComponent();
           
            ViewInstructorInfo_Load();
            
        }

        private void ViewInstructorInfo_Load()
        {
            lv_giverncourses.Items.Clear();
            String str = "select * from inst where instid=" + instructor_id;
         
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(str, connection))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                DataRow dataRow = datatable.Rows[0];
             //   lbl_StuID.Text = dataRow[0].ToString();
                lbl_fname.Text = dataRow[1].ToString();
                lbl_lname.Text = dataRow[2].ToString();
                lbl_gender.Text = dataRow[3].ToString();
                lbl_nationality.Text = dataRow[4].ToString();
                lbl_NationalId.Text = dataRow[5].ToString();
                lbl_email.Text = dataRow[6].ToString();
                lbl_phoneNO.Text = dataRow[7].ToString();
            }

             str = "select c.courseid,c.cname,c.credits from inst_COURSE ic , course c where c.courseid=ic.courseid and ic.instid=" + instructor_id;
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(str, connection))
            {// to find the given courses codes

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                givenCourses = new String[datatable.Rows.Count];
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow dataRow = datatable.Rows[i];
                    givenCourses[i] = dataRow[0].ToString();
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    lvi.SubItems.Add(dataRow[1].ToString());
                    lv_giverncourses.Items.Add(lvi);
                  //  MessageBox.Show(givenCourses[i]);
                  //  clistbox_Courses.Items.Insert(0, dataRow[0].ToString()+": "+ dataRow[1].ToString());
                   // clistbox_Courses.Items.Add(lvi,true);

                }
            }

           





        }

        private void clistbox_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_giverncourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Instructor_Courses_Dialog addcourse = new Add_Instructor_Courses_Dialog(instructor_id, givenCourses);
            addcourse.ShowDialog();
            ViewInstructorInfo_Load();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String coursecode = lv_giverncourses.SelectedItems[0].SubItems[0].Text;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string queryString = "delete from inst_Course where instid=@instid and courseid=@courseid";

                    using (SqlCommand cmd = new SqlCommand(queryString))
                    {
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@instid", instructor_id);
                        cmd.Parameters.AddWithValue("@courseid", coursecode);
                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("the Course Removed !!");
                ViewInstructorInfo_Load();

            }
            catch (Exception)
            {
                MessageBox.Show("select a course to remove");
            }

        }
    }
}
