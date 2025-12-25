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
    public partial class return_books : Form
    {
        string connStr =
            @"Data Source=HACKY_BOY\SQLEXPRESS;
              Initial Catalog=lms;
              Integrated Security=True;
              TrustServerCertificate=True";

        public return_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            fill_Grid(textBox1.Text);
        }

        private void return_books_Load(object sender, EventArgs e)
        {

        }

        public void fill_Grid(string enrollment)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM issue_books WHERE student_enrollment = @enrollment", conn))
                {
                    cmd.Parameters.AddWithValue("@enrollment", enrollment);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM issue_books where id = " + i + "", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                lbl_booksName.Text = dr["books_name"].ToString();
                                lbl_issueDate.Text = dr["books_issue_date"].ToString();
                            }

                            dataGridView1.DataSource = dt;
                        }
                        cmd.ExecuteNonQuery();
                    }
                    dateTimePicker1.MinDate = Convert.ToDateTime(lbl_issueDate.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(@"update books_info set available_qty = available_qty + 1 where books_name = '" + lbl_booksName.Text + "'", conn);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(@"update issue_books set books_return_date = '"+ dateTimePicker1.Value.ToString()+"' where Id = " + i + "" , conn);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand(@"delete from issue_books where Id = "+ i +"");
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Book returned successfully");

            panel3.Visible = false;
            fill_Grid(textBox1.Text);

        }
    }
}
