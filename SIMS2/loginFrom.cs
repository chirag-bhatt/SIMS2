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
    public partial class loginFrom : Form
    {
        SqlConnection sql_connection;
        String connectionString;
         
        private String user = "user";
        private String pass = "1234";

        public loginFrom()
        {
            InitializeComponent();
            connectionString=ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString;
            

            
        }
      
        //for my database access and write
         SqlConnection con;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;
        DataSet ds;
        DataTable dt;
        DataRow dr;

        private void loginFrom_Load(object sender, EventArgs e)
        {

            using (sql_connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from staff", sql_connection))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                listBox1.DisplayMember = "fname";
                listBox1.ValueMember = "id";
                listBox1.DataSource = datatable;

              
             

                

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {



            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SIMS2.Properties.Settings.Database1_ConnectionString"].ConnectionString);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            if(comboBox1.SelectedIndex == 0)
            {
                //student
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //Instructor
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //Staff
                adp.SelectCommand = new SqlCommand("select id, password from staff", con);
                adp.Fill(ds, "myData");
                dt = ds.Tables["myData"];
                // dr = dt.Rows[0];
                dg.DataSource = ds.Tables["mydata"];

                int auth_flag = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    string password = dr["password"].ToString();
                    string Id = dr["Id"].ToString();
                    //removing spaces so the if conditin works 
                    password = password.Replace(" ", String.Empty);
                    Id = Id.Replace(" ", String.Empty);
                    if (Id == tb_username.Text && tb_password.Text == password)
                    {

                        this.Hide();
                        new Staff_Form().Show();
                        auth_flag = 1;
                        break;
                    }

                }
                if (auth_flag == 0)
                {
                    MessageBox.Show("please try again", "login failed", MessageBoxButtons.OK);
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridtest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
