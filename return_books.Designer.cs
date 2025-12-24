namespace Library_Management_System
{
    partial class return_books
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label6 = new Label();
            lbl_issueDate = new Label();
            label4 = new Label();
            lbl_booksName = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 363);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift SemiCondensed", 14F);
            button1.Location = new Point(43, 147);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift SemiCondensed", 14F);
            textBox1.Location = new Point(43, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 41);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 28);
            label1.Name = "label1";
            label1.Size = new Size(243, 34);
            label1.TabIndex = 0;
            label1.Text = "Enter Enrollment No.";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(472, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1132, 363);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1126, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lbl_issueDate);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lbl_booksName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 381);
            panel3.Name = "panel3";
            panel3.Size = new Size(1592, 363);
            panel3.TabIndex = 2;
            panel3.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Bahnschrift", 14F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(300, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 41);
            dateTimePicker1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift SemiCondensed", 14F);
            button2.Location = new Point(251, 260);
            button2.Name = "button2";
            button2.Size = new Size(135, 45);
            button2.TabIndex = 3;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 144);
            label6.Name = "label6";
            label6.Size = new Size(251, 34);
            label6.TabIndex = 7;
            label6.Text = "Select Return Date";
            // 
            // lbl_issueDate
            // 
            lbl_issueDate.AutoSize = true;
            lbl_issueDate.BorderStyle = BorderStyle.FixedSingle;
            lbl_issueDate.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_issueDate.Location = new Point(729, 39);
            lbl_issueDate.Name = "lbl_issueDate";
            lbl_issueDate.Size = new Size(2, 36);
            lbl_issueDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(596, 39);
            label4.Name = "label4";
            label4.Size = new Size(127, 34);
            label4.TabIndex = 5;
            label4.Text = "Issue Date";
            // 
            // lbl_booksName
            // 
            lbl_booksName.AutoSize = true;
            lbl_booksName.BorderStyle = BorderStyle.FixedSingle;
            lbl_booksName.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_booksName.Location = new Point(209, 39);
            lbl_booksName.Name = "lbl_booksName";
            lbl_booksName.Size = new Size(2, 36);
            lbl_booksName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 39);
            label2.Name = "label2";
            label2.Size = new Size(151, 34);
            label2.TabIndex = 3;
            label2.Text = "Books Name";
            // 
            // return_books
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 756);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "return_books";
            Text = "return_books";
            Load += return_books_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button button2;
        private Label label6;
        private Label lbl_issueDate;
        private Label label4;
        private Label lbl_booksName;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}