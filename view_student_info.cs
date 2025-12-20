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
                        new SqlDataAdapter("SELECT * FROM student_info where student_name like ('%" + textBox1.Text + "%')", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            panel1.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            //MessageBox.Show(i.ToString());
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM student_info where id = " + i + "", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                s_name.Text = dr["student_name"].ToString();
                                s_enrollment.Text = dr["student_enrollment_no"].ToString();
                                s_semester.Text = dr["student_sem"].ToString();
                                s_contact.Text = dr["student_contact"].ToString();
                                s_email.Text = dr["student_email"].ToString();
                                s_department.Text = dr["student_department"].ToString();
                            }
                            dataGridView1.DataSource = dt;
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"UPDATE student_info SET 
              student_name=@name,
              student_enrollment_no=@enrollment,
              student_department=@department,
              student_sem=@semester,
              student_contact=@contact,
              student_email=@email
              WHERE id=@id", conn);

                    cmd.Parameters.AddWithValue("@name", s_name.Text);
                    cmd.Parameters.AddWithValue("@enrollment", s_enrollment.Text);
                    cmd.Parameters.AddWithValue("@department", s_department.Text);
                    cmd.Parameters.AddWithValue("@semester", s_semester.Text);
                    cmd.Parameters.AddWithValue("@contact", s_contact.Text);
                    cmd.Parameters.AddWithValue("@email", s_email.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                LoadStudents();
                panel1.Visible = false;
                MessageBox.Show("Student Info updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
