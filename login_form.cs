using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class login_form : Form
    {
        //AttachedDBFilename=|DataDirectory|\lms.mdf;
        string connStr = Properties.Settings.Default.LibraryConnection;


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
            SqlConnection con = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM library_person WHERE username=@u AND password=@p",
                con);

            cmd.Parameters.AddWithValue("@u", textBox1.Text);
            cmd.Parameters.AddWithValue("@p", textBox2.Text);

            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (count > 0)
            {
                new mdi_user().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

    }
}
