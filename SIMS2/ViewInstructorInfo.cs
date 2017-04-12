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

        public ViewInstructorInfo()
        {
            InitializeComponent();
        }

        public ViewInstructorInfo(int id )
        {
            InitializeComponent();
            ViewInstructorInfo_Load(id);

        }

        private void ViewInstructorInfo_Load(int id)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from inst", connection))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                DataRow dataRow = datatable.Rows[0];
             //   lbl_StuID.Text = dataRow[0].ToString();
                lbl_fname.Text = dataRow[1].ToString();
                lbl_lname.Text = dataRow[2].ToString();
                lbl_gender.Text = dataRow[3].ToString();
                lbl_NationalId.Text = dataRow[4].ToString();
                lbl_NationalId.Text = dataRow[5].ToString();
                lbl_email.Text = dataRow[6].ToString();
                lbl_phoneNO.Text = dataRow[7].ToString();



            }


        }


    }
}
