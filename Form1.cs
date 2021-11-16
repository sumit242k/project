using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME ss = new HOME();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOOB-PC;Initial Catalog=userregdb;Integrated Security=True");
            string query = "select * from registable Where username = '" + username.Text.Trim() + "' and password='" + password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count ==1)
            {
                homepage objhomepage = new homepage();
                this.Hide();
                objhomepage.Show();
            }
            else
            {
                MessageBox.Show("check you username and password");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            REGISTER ss = new REGISTER();
            ss.Show();
        }
    }
}
