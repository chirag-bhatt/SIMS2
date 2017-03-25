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
            // if(tb_username.Text==user && tb_password.Text == pass)
      
            this.Hide();
            new Staff_Form().Show();
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

       
    }
}
