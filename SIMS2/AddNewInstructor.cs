using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;



namespace SIMS2
{
    public partial class AddNewInstructor : Form
    {
        SqlConnection sql_connection;
        //for my database access and write
        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;
        DataSet ds;
        DataTable dt;
        DataRow dr;

        SqlConnection connection;
        String connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
        public AddNewInstructor()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddNewInstructor_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select dname from department", connection))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                cmb_Faculty.DataSource = datatable;
                cmb_Faculty.DisplayMember = "dname";
                cmb_Faculty.ValueMember = "dname";

            }
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();

            string fname = textBox3.Text;
            string lname = textBox2.Text;
            string gender = comboBox1.SelectedText;
            string nationality = comboBox2.SelectedText;
            int nationalId = Convert.ToInt32(tb_NationalId.Text);
            string email = tb_Email.Text;
            string phonenum = tb_PhoneNumber.Text;
            try
            {
                // fixed the insert by removing the id column
                SqlCommand command1 = new SqlCommand("INSERT INTO inst VALUES( 'john', 'smith', 'male', 'american', 111111111, 'john@gmail.com', 222222222)", con);

                command1.Parameters.AddWithValue("@fname", fname);
                command1.Parameters.AddWithValue("@lname", lname);
                command1.Parameters.AddWithValue("@gender", gender);
                command1.Parameters.AddWithValue("@nationality", nationality);
                command1.Parameters.AddWithValue("@nationalId", nationalId);
                command1.Parameters.AddWithValue("@email", email);
                command1.Parameters.AddWithValue("@phonenum", phonenum);
                command1.ExecuteNonQuery();
                MessageBox.Show("Row inserted !! ");
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // we shd check that d.dname = cmb_Faculty.SelectedText
            string Selected_department = cmb_Faculty.SelectedText;
            //string query = "SELECT cname FROM course c,department d,Dept_Course dc WHERE d.deptId = dc.deptId and c.courseId = dc.courseId and d.dname = " + cmb_Faculty.SelectedText + ";";
            string query = "SELECT cname FROM course c,department d,Dept_Course dc WHERE d.deptId = dc.deptId and c.courseId = dc.courseId;";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                    try
                    {
                        DataTable datatable = new DataTable();
                        adapter.Fill(datatable);
                        comboBox3.DataSource = datatable;
                        comboBox3.DisplayMember = "cname";
                        comboBox3.ValueMember = "cname";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                   

            }

        }
    }
}
