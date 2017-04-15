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
    public partial class RegisterNewStudentForm : Form
    {
        SqlConnection sql_connection;
        String connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
        //for my database access and write
        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;
        DataSet ds;
        DataTable dt;
    
        public RegisterNewStudentForm()
        {
            InitializeComponent();
        //    lv_courses.CheckBoxes = true;
          //  load_data(); // look like we find eaiser way to do this 
        }

        private void load_data() 
        { // to load the departments names  into the cmb_departments
            using (con = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from department", con))
            {

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                for(int i = 0; i < datatable.Rows.Count; i++)
                {
                    DataRow dataRow = datatable.Rows[i];
                    cmb_Department.Items.Add(dataRow[1].ToString());
                    

                }

            }


        }
        private void cmb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {// to load the courses for the selected department

            lv_courses.Items.Clear();
            String dept_id = Convert.ToString(cmb_Department.SelectedValue) ;
           // MessageBox.Show(dept_id);
           
              String query = "select courseId, cname, credits from course where courseId in( select courseId from Dept_course where deptId== @id)";
            

                DataTable datatable = new DataTable();
               // MySqlConnection conn = new MySqlConnection(@"connection string");//tested and working
                con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand( "select courseId, cname, credits from course where courseId in( select courseId from Dept_course where deptId = @id)");
                 cmd.Parameters.AddWithValue("@id", dept_id);
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Connection = con;
                adapter.SelectCommand = cmd;
                adapter.Fill(datatable);
               
 
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                DataRow dataRow = datatable.Rows[i];
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = dataRow[0].ToString();
                lvItem.SubItems.Add(dataRow[1].ToString());
                lvItem.SubItems.Add(dataRow[2].ToString());

                lv_courses.Items.Add(lvItem);

            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            adp = new SqlDataAdapter();
            ds = new DataSet();

            con.Open();
            string fname = textBox3.Text;
            string lname = textBox2.Text;
            string fathername = textBox7.Text;
            string bday = dateTimePicker1.Text;
            string gender = comboBox1.SelectedText;
            DateTime localDate = DateTime.Now;
            string registerationDate = localDate.ToString();
            MessageBox.Show(registerationDate);
            string nationality = comboBox2.SelectedText;
            int nationalId = Convert.ToInt32(tb_NationalId.Text);
            string passport = tb_PassportNo.Text;
            string adress = textBox1.Text;
            string email = tb_Email.Text;
            string phonenum = tb_PhoneNumber.Text;
            //"INSERT INTO student VALUES (123456,'1','2','3','11/2/1997','male','1/1/2010','Egyptian',12345678910,'A00000000','istanbul-goztepe','A@b.com','+9659789519');
            //adp.InsertCommand = new SqlCommand("INSERT INTO student VALUES (123456,fname,lname,fathername,bday,gender,registerationDate,nationality,nationalId,passport,adress,email,phonenum);", con);
            try
            {
                

                SqlCommand command1 = new SqlCommand("INSERT INTO student VALUES (@fname,@lname,@fathername,'1/1/2010',@gender,@registerationDate,@nationality,@nationalId,@passport,@adress,@email,@phonenum);", con);

                //@fname,@lname,@fathername,@bday,@gender,@registerationDate,@nationality,@nationalId,@passport,@adress,@email,@phonenum

                command1.Parameters.AddWithValue("@fname", fname);
                command1.Parameters.AddWithValue("@lname", lname);
                command1.Parameters.AddWithValue("@fathername",fathername);
                command1.Parameters.AddWithValue("@bday", bday);
                command1.Parameters.AddWithValue("@gender", gender);
                command1.Parameters.AddWithValue("@registerationDate", registerationDate);
                command1.Parameters.AddWithValue("@nationality", nationality);
                command1.Parameters.AddWithValue("@nationalId", nationalId);
                command1.Parameters.AddWithValue("@passport", passport);
                command1.Parameters.AddWithValue("@adress", adress);
                command1.Parameters.AddWithValue("@email", email);
                command1.Parameters.AddWithValue("@phonenum", phonenum);

                //adp.InsertCommand = command1;
                command1.ExecuteNonQuery();
               // adp.InsertCommand.ExecuteNonQuery();
                 MessageBox.Show("Row inserted !! ");
                adp.SelectCommand = new SqlCommand("select * from student", con);
                adp.Fill(ds, "myData");
                dt = ds.Tables["myData"];
                // dr = dt.Rows[0];
                dg.DataSource = ds.Tables["mydata"];
                con.Close();

            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }

            //adp.InsertCommand = new SqlCommand("INSERT INTO student VALUES (1502581,'1','2','3','11/2/1997','male','1/1/2010','Egyptian',12345678910,'A00000000','istanbul-goztepe','A@b.com','+9659789519');", con);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterNewStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.department' table. You can move, or remove it, as needed.
         //   this.departmentTableAdapter.Fill(this.database1DataSet1.department);
            // TODO: This line of code loads data into the 'database1DataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.database1DataSet.department);
        }
    }
}
