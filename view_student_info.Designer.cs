namespace Library_Management_System
{
    partial class view_student_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            button1 = new Button();
            label7 = new Label();
            s_contact = new TextBox();
            label6 = new Label();
            s_department = new TextBox();
            label5 = new Label();
            s_semester = new TextBox();
            label4 = new Label();
            s_email = new TextBox();
            label3 = new Label();
            s_enrollment = new TextBox();
            label2 = new Label();
            s_name = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1276, 452);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 12F);
            textBox1.Location = new Point(12, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 36);
            textBox1.TabIndex = 1;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F);
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(281, 29);
            label1.TabIndex = 2;
            label1.Text = "Search Student By Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(s_contact);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(s_department);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(s_semester);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(s_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(s_enrollment);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(s_name);
            panel1.Location = new Point(12, 479);
            panel1.Name = "panel1";
            panel1.Size = new Size(1563, 273);
            panel1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(49, 25);
            label9.Name = "label9";
            label9.Size = new Size(212, 36);
            label9.TabIndex = 15;
            label9.Text = "Update Details";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(965, 96);
            button1.Name = "button1";
            button1.Size = new Size(175, 154);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F);
            label7.Location = new Point(507, 217);
            label7.Name = "label7";
            label7.Size = new Size(95, 29);
            label7.TabIndex = 11;
            label7.Text = "Contact";
            // 
            // s_contact
            // 
            s_contact.Font = new Font("Bahnschrift", 12F);
            s_contact.Location = new Point(645, 214);
            s_contact.Name = "s_contact";
            s_contact.Size = new Size(245, 36);
            s_contact.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F);
            label6.Location = new Point(25, 217);
            label6.Name = "label6";
            label6.Size = new Size(141, 29);
            label6.TabIndex = 9;
            label6.Text = "Department";
            // 
            // s_department
            // 
            s_department.Font = new Font("Bahnschrift", 12F);
            s_department.Location = new Point(174, 214);
            s_department.Name = "s_department";
            s_department.Size = new Size(245, 36);
            s_department.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F);
            label5.Location = new Point(507, 96);
            label5.Name = "label5";
            label5.Size = new Size(118, 29);
            label5.TabIndex = 7;
            label5.Text = "Semester";
            // 
            // s_semester
            // 
            s_semester.Font = new Font("Bahnschrift", 12F);
            s_semester.Location = new Point(645, 96);
            s_semester.Name = "s_semester";
            s_semester.Size = new Size(245, 36);
            s_semester.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F);
            label4.Location = new Point(507, 156);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // s_email
            // 
            s_email.Font = new Font("Bahnschrift", 12F);
            s_email.Location = new Point(645, 153);
            s_email.Name = "s_email";
            s_email.Size = new Size(245, 36);
            s_email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F);
            label3.Location = new Point(25, 156);
            label3.Name = "label3";
            label3.Size = new Size(132, 29);
            label3.TabIndex = 3;
            label3.Text = "Enrollment";
            // 
            // s_enrollment
            // 
            s_enrollment.Font = new Font("Bahnschrift", 12F);
            s_enrollment.Location = new Point(174, 153);
            s_enrollment.Name = "s_enrollment";
            s_enrollment.Size = new Size(245, 36);
            s_enrollment.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F);
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // s_name
            // 
            s_name.Font = new Font("Bahnschrift", 12F);
            s_name.Location = new Point(174, 96);
            s_name.Name = "s_name";
            s_name.Size = new Size(245, 36);
            s_name.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // view_student_info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 764);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "view_student_info";
            Text = "View Student Info";
            Load += view_student_info_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox s_name;
        private Label label4;
        private TextBox s_email;
        private Label label3;
        private TextBox s_enrollment;
        private Label label7;
        private TextBox s_contact;
        private Label label6;
        private TextBox s_department;
        private Label label5;
        private TextBox s_semester;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Label label9;
    }
}