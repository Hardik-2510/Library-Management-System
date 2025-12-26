using Microsoft.Data.SqlClient;
using System.Data;

namespace Library_Management_System
{
    public partial class view_books : Form
    {
        string connStr = Properties.Settings.Default.LibraryConnection;
        public view_books()
        {
            InitializeComponent();
        }
        private void view_books_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT * FROM books_info";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            //MessageBox.Show(i.ToString());
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM books_info where id = " + i + "", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                bookname.Text = dr["books_name"].ToString();
                                authorname.Text = dr["books_author_name"].ToString();
                                publicationname.Text = dr["books_publication_name"].ToString();
                                dateTimePicker1.Value = Convert.ToDateTime(dr["books_purchase_date"].ToString());
                                bookprice.Text = dr["books_price"].ToString();
                                bookquantity.Text = dr["books_quantity"].ToString();
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
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM books_info where books_name like('%" + textBox1.Text + "%')", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM books_info where books_name like('%" + textBox1.Text + "%')", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM books_info where books_author_name like('%" + textBox2.Text + "%')", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
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

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM books_info where books_author_name like('%" + textBox2.Text + "%')", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM books_info", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE books_info SET 
              books_name=@name,
              books_author_name=@author,
              books_publication_name=@pub,
              books_purchase_date=@date,
              books_price=@price,
              books_quantity=@qty
              WHERE id=@id", conn);

                cmd.Parameters.AddWithValue("@name", bookname.Text);
                cmd.Parameters.AddWithValue("@author", authorname.Text);
                cmd.Parameters.AddWithValue("@pub", publicationname.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@price", bookprice.Text);
                cmd.Parameters.AddWithValue("@qty", bookquantity.Text);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            LoadBooks();

            MessageBox.Show("Book updated successfully");
        }
    }
}
