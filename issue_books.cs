using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class issue_books : Form
    {
        string connStr =
            @"Data Source=HACKY_BOY\SQLEXPRESS;
              Initial Catalog=lms;
              Integrated Security=True;
              TrustServerCertificate=True";
        public issue_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                int i = 0;
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "select * from student_info where student_enrollment_no = " + enrollment_txt.Text + "", conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        i = Convert.ToInt32(dt.Rows.Count.ToString());
                        if (i == 0)
                        {
                            MessageBox.Show("Student Not Found !");
                        }
                        else
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                s_name.Text = dr["student_name"].ToString();
                                s_semester.Text = dr["student_sem"].ToString();
                                s_contact.Text = dr["student_contact"].ToString();
                                s_email.Text = dr["student_email"].ToString();
                                s_department.Text = dr["student_department"].ToString();
                            }
                            //cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
            }
        }

        private void book_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return;

            listBox1.Items.Clear();
            listBox1.Visible = false;

            if (string.IsNullOrWhiteSpace(book_name.Text))
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT books_name FROM books_info WHERE books_name LIKE @name", conn))
            {
                cmd.Parameters.AddWithValue("@name", "%" + book_name.Text + "%");

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    listBox1.Visible = true;

                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["books_name"]?.ToString());
                    }
                }
            }
        }

        private void book_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && listBox1.Items.Count > 0)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && listBox1.SelectedItem != null)
            {
                book_name.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
                book_name.Focus();
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                book_name.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
                book_name.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO issue_books 
        (student_name, student_enrollment, student_sem, student_contact, 
         student_email, student_dept, books_name, books_issue_date)
         VALUES 
        (@student_name, @student_enrollment_no, @student_sem, @student_contact, 
         @student_email, @student_dept, @books_name, @books_issue_date)",
                        conn);

                    // Passing values safely
                    cmd.Parameters.AddWithValue("@student_name", s_name.Text);
                    cmd.Parameters.AddWithValue("@student_enrollment_no", enrollment_txt.Text);
                    cmd.Parameters.AddWithValue("@student_sem", s_semester.Text);
                    cmd.Parameters.AddWithValue("@student_contact", s_contact.Text);
                    cmd.Parameters.AddWithValue("@student_email", s_email.Text);
                    cmd.Parameters.AddWithValue("@student_dept", s_department.Text);
                    cmd.Parameters.AddWithValue("@books_name", book_name.Text);
                    cmd.Parameters.AddWithValue("@books_issue_date", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Book issued successfully");

                s_contact.Clear();
                s_department.Clear();
                s_name.Clear();
                s_email.Clear();
                enrollment_txt.Clear();
                s_semester.Clear();
                book_name.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
