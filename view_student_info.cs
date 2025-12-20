using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class view_student_info : Form
    {
        string connStr =
            @"Data Source=HACKY_BOY\SQLEXPRESS;
              Initial Catalog=lms;
              Integrated Security=True;
              TrustServerCertificate=True";

        public view_student_info()
        {
            InitializeComponent();
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT * FROM student_info", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
            }

            //ConvertImageColumn();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();
                    conn.Open();
                    SqlDataAdapter da =
                        new SqlDataAdapter("SELECT * FROM student_info where student_name like ('%" +textBox1.Text+ "%')", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
