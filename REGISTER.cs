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


namespace WindowsFormsApp1
{
  
    public partial class REGISTER : Form
    {
        string connectionstring = @"Data Source=NOOB-PC;Initial Catalog=userregdb;Integrated Security=True";
        public REGISTER()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (txtusername.Text == "" || txtpassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (txtpassword.Text != txtconfirmpassword.Text)
                MessageBox.Show("password do not match");
            else {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("useradd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@firstname", txtfirstname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@lastname", txtlastname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@gender", cmbbgender.ToString().Trim());
                    sqlcmd.Parameters.AddWithValue("@nationality", cmbbnationality.ToString().Trim());
                    sqlcmd.Parameters.AddWithValue("@emailid", txtemailid.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@confirmpassword", txtconfirmpassword.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("registeration is successfull");
                    clear();
                }

            }
        }
        void clear()
        {
            txtfirstname.Text = txtlastname.Text = txtemailid.Text = txtphonenumber.Text = txtpassword.Text = txtconfirmpassword.Text = txtusername.Text = "";
        }
    }
}
