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
    public partial class Staff_Form : Form
    {
        SqlConnection connection;
        String connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;


        public Staff_Form()
        {
            InitializeComponent();
            
        }

        private void btn_chagneConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void cmb_SearchStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btn_RegisterNewStudent_Click(object sender, EventArgs e)
        {
            new RegisterNewStudentForm().ShowDialog();
        }

        private void Staff_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.student' table. You can move, or remove it, as needed.
          //  this.studentTableAdapter.Fill(this.database1DataSet.student); i do not know about this ???



            // to fill the cmb_SearchStudent wiht students ids
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select studentId from student", connection))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                cmb_SearchStudent.DataSource = datatable;
                cmb_SearchStudent.DisplayMember = "studentid";
                cmb_SearchStudent.ValueMember = "studentid";

            }
            //to fill instructors in the cmb_SearchInstructor wiht instructor id
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select instId from inst", connection))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                cmb_SearchInstructor.DataSource = datatable;
                cmb_SearchInstructor.DisplayMember = "instId";
                cmb_SearchInstructor.ValueMember = "instId";

            }


        }

        private void btn_SelectStu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmb_SearchStudent.Text);
            ViewStudentInfo vsfForm = new ViewStudentInfo(id);
            vsfForm.ShowDialog();

        }

        private void btn_SelectInstructor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmb_SearchInstructor.Text);
            ViewInstructorInfo vIIForm = new ViewInstructorInfo(id);
            vIIForm.ShowDialog();
        }

        private void btn_RegisterNewInstructor_Click(object sender, EventArgs e)
        {
            new AddNewInstructor().ShowDialog();
        }
    }
}