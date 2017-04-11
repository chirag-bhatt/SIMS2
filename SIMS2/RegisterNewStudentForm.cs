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
        String connectionString;
        //for my database access and write
        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public RegisterNewStudentForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString);
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
                

                SqlCommand command1 = new SqlCommand("INSERT INTO student VALUES (123456,@fname,@lname,@fathername,'1/1/2010',@gender,@registerationDate,@nationality,@nationalId,@passport,@adress,@email,@phonenum);", con);

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

       
    }
}
