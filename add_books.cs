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
    public partial class add_books : Form
    {
        string connStr =
            @"Data Source=HACKY_BOY\SQLEXPRESS;
              Initial Catalog=lms;
              Integrated Security=True;
              TrustServerCertificate=True";
        public add_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO books_info VALUES (@bname,@author,@publisher,@purchase_date,@price,@qty)", con))
                {
                    cmd.Parameters.AddWithValue("@bname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@author", textBox2.Text);
                    cmd.Parameters.AddWithValue("@publisher", textBox3.Text);
                    cmd.Parameters.AddWithValue("@purchase_date", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(textBox5.Text));
                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(textBox6.Text));

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Book added successfully");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
