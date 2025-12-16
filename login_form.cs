using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class login_form : Form
    {
        string connStr =
        @"Data Source=HACKY_BOY\SQLEXPRESS;
          Initial Catalog=lms;
          Integrated Security=True;
          TrustServerCertificate=True";

        
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            // optional
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query =
                    "SELECT COUNT(*) FROM dbo.library_person WHERE username=@u AND password=@p";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", textBox2.Text.Trim());

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        this.Hide();
                        new mdi_user().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
            }
        }
    }
}
