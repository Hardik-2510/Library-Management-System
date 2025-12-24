using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class add_student_info : Form
    {
        string connStr =
            @"Data Source=HACKY_BOY\SQLEXPRESS;
              Initial Catalog=lms;
              Integrated Security=True;
              TrustServerCertificate=True";

        string imageRelativePath = string.Empty;

        public add_student_info()
        {
            InitializeComponent();
        }

        private void add_student_info_Load(object sender, EventArgs e)
        {
            // Optional: initialization code
        }


        // Save student
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO student_info
                          (student_name, student_enrollment_no,
                           student_department, student_sem, student_contact, student_email)
                          VALUES
                          (@name, @enroll, @dept, @sem, @contact, @email)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@enroll", textBox2.Text);
                        cmd.Parameters.AddWithValue("@dept", textBox4.Text);
                        cmd.Parameters.AddWithValue("@sem", textBox3.Text);
                        cmd.Parameters.AddWithValue("@contact", textBox5.Text);
                        cmd.Parameters.AddWithValue("@email", textBox6.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student added successfully");

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            imageRelativePath = string.Empty;
        }
    }
}
