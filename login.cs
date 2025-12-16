using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class login_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HACKY_BOY\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        int count = 0;
        public login_form()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from library_person where username= '" + textBox1.Text +"' and password='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {
             if(con.State == ConnectionState.Open)
            {
                con.Close();    
            }
             con.Open();
        }
    }
}
