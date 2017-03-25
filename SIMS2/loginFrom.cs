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

namespace SIMS2
{
    public partial class loginFrom : Form
    {
        private String user = "user";
        private String pass = "1234";

        public loginFrom()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // if(tb_username.Text==user && tb_password.Text == pass)

            this.Hide();
            new Staff_Form().Show();
            

                
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

        }
    }
}
