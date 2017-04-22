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
    public partial class Add_Instructor_Courses_Dialog : Form
    {
        private SqlConnection connection;
        int instructor_id;
        String[] givenCourses;
        String connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
        
        public Add_Instructor_Courses_Dialog(int id, String []Courses)
        {
            this.instructor_id = id;
            this.givenCourses = Courses;
            InitializeComponent();
            
            String str = "select courseid,cname from course";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(str, connection))
            {// to retrive all courses

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
               
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow dataRow = datatable.Rows[i];

                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    lvi.SubItems.Add(dataRow[1].ToString());
                    lv_giverncourses.Items.Add(lvi);
                   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String coursecode = lv_giverncourses.SelectedItems[0].SubItems[0].Text;
                if (Array.IndexOf(givenCourses, coursecode) == -1)
                {
                    // MessageBox.Show(coursecode.ToString() + " " + instructor_id);
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string queryString = "INSERT into inst_Course  VALUES (@instid,@courseid)";

                        using (SqlCommand cmd = new SqlCommand(queryString))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@instid", instructor_id);
                            cmd.Parameters.AddWithValue("@courseid", coursecode);
                            con.Open();
                            cmd.ExecuteNonQuery();

                        }
                    }
                    MessageBox.Show("The course is added !!");
                    this.Dispose();

                }
                else MessageBox.Show("this course is already added !!");

            }
            catch (Exception)
            {
                MessageBox.Show("select a course to add!");
            }
          

        }
    }
}
