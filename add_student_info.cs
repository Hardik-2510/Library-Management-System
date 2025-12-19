using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
        string pwd = RandomPassword.GetRandomPassword(20);
        string wanted_path = string.Empty;
        public add_student_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) ?? string.Empty;
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
            using (SqlConnection conn = new SqlConnection(connStr)) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(" INSERT INTO student_info VALUES () " , conn))
                {

                }
            }
        }
    }
}
