namespace Library_Management_System
{
    partial class issue_books
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
            panel1 = new Panel();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            book_name = new TextBox();
            label8 = new Label();
            label7 = new Label();
            s_email = new TextBox();
            label6 = new Label();
            s_contact = new TextBox();
            label5 = new Label();
            s_semester = new TextBox();
            label4 = new Label();
            s_department = new TextBox();
            label3 = new Label();
            s_name = new TextBox();
            label2 = new Label();
            button1 = new Button();
            enrollment_txt = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(book_name);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(s_email);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(s_contact);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(s_semester);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(s_department);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(s_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(enrollment_txt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 866);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(756, 570);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(336, 204);
            listBox1.TabIndex = 19;
            listBox1.Visible = false;
            listBox1.MouseClick += listBox1_MouseClick;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(756, 454);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(336, 31);
            dateTimePicker1.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(756, 801);
            button2.Name = "button2";
            button2.Size = new Size(184, 49);
            button2.TabIndex = 17;
            button2.Text = "Issue Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // book_name
            // 
            book_name.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            book_name.Location = new Point(756, 534);
            book_name.Name = "book_name";
            book_name.Size = new Size(336, 36);
            book_name.TabIndex = 16;
            book_name.KeyDown += book_name_KeyDown;
            book_name.KeyUp += book_name_KeyUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(523, 537);
            label8.Name = "label8";
            label8.Size = new Size(137, 29);
            label8.TabIndex = 15;
            label8.Text = "Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(523, 454);
            label7.Name = "label7";
            label7.Size = new Size(126, 29);
            label7.TabIndex = 13;
            label7.Text = "Issue Date";
            // 
            // s_email
            // 
            s_email.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_email.Location = new Point(756, 373);
            s_email.Name = "s_email";
            s_email.Size = new Size(336, 36);
            s_email.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(523, 376);
            label6.Name = "label6";
            label6.Size = new Size(163, 29);
            label6.TabIndex = 11;
            label6.Text = "Student Email";
            // 
            // s_contact
            // 
            s_contact.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_contact.Location = new Point(756, 290);
            s_contact.Name = "s_contact";
            s_contact.Size = new Size(336, 36);
            s_contact.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(523, 293);
            label5.Name = "label5";
            label5.Size = new Size(184, 29);
            label5.TabIndex = 9;
            label5.Text = "Student Contact";
            // 
            // s_semester
            // 
            s_semester.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_semester.Location = new Point(756, 205);
            s_semester.Name = "s_semester";
            s_semester.Size = new Size(336, 36);
            s_semester.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(523, 208);
            label4.Name = "label4";
            label4.Size = new Size(207, 29);
            label4.TabIndex = 7;
            label4.Text = "Student Semester";
            // 
            // s_department
            // 
            s_department.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_department.Location = new Point(756, 128);
            s_department.Name = "s_department";
            s_department.Size = new Size(336, 36);
            s_department.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(523, 131);
            label3.Name = "label3";
            label3.Size = new Size(230, 29);
            label3.TabIndex = 5;
            label3.Text = "Student Department";
            // 
            // s_name
            // 
            s_name.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_name.Location = new Point(756, 50);
            s_name.Name = "s_name";
            s_name.Size = new Size(336, 36);
            s_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(523, 53);
            label2.Name = "label2";
            label2.Size = new Size(166, 29);
            label2.TabIndex = 3;
            label2.Text = "Student Name";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(48, 139);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // enrollment_txt
            // 
            enrollment_txt.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enrollment_txt.Location = new Point(48, 85);
            enrollment_txt.Name = "enrollment_txt";
            enrollment_txt.Size = new Size(336, 36);
            enrollment_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 53);
            label1.Name = "label1";
            label1.Size = new Size(237, 29);
            label1.TabIndex = 0;
            label1.Text = "Enter Enrollment No.";
            // 
            // issue_books
            // 
            ClientSize = new Size(1361, 890);
            Controls.Add(panel1);
            Name = "issue_books";
            Text = "Issue Book";
            Load += issue_books_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        private Panel panel1;
        private Button button1;
        private TextBox enrollment_txt;
        private Label label1;
        private Button button2;
        private TextBox book_name;
        private Label label8;
        private Label label7;
        private TextBox s_email;
        private Label label6;
        private TextBox s_contact;
        private Label label5;
        private TextBox s_semester;
        private Label label4;
        private TextBox s_department;
        private Label label3;
        private TextBox s_name;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
    }
}
#endregion