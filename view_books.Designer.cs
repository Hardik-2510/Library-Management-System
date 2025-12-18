namespace Library_Management_System
{
    partial class view_books
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
            panel1 = new Panel();
            label10 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            bookquantity = new TextBox();
            label9 = new Label();
            bookprice = new TextBox();
            label8 = new Label();
            label7 = new Label();
            publicationname = new TextBox();
            label6 = new Label();
            authorname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            bookname = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(522, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1212, 485);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 485);
            panel1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(153, 38);
            label10.Name = "label10";
            label10.Size = new Size(227, 39);
            label10.TabIndex = 20;
            label10.Text = "Search Details";
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift", 14F);
            button2.Location = new Point(359, 356);
            button2.Name = "button2";
            button2.Size = new Size(141, 46);
            button2.TabIndex = 7;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift", 14F);
            button1.Location = new Point(359, 207);
            button1.Name = "button1";
            button1.Size = new Size(141, 46);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bahnschrift", 14F);
            textBox2.Location = new Point(91, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 41);
            textBox2.TabIndex = 5;
            textBox2.KeyUp += textBox2_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14F);
            label2.Location = new Point(8, 272);
            label2.Name = "label2";
            label2.Size = new Size(260, 34);
            label2.TabIndex = 4;
            label2.Text = "Enter Author Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 14F);
            textBox1.Location = new Point(91, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 41);
            textBox1.TabIndex = 3;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.Location = new Point(8, 123);
            label1.Name = "label1";
            label1.Size = new Size(237, 34);
            label1.TabIndex = 2;
            label1.Text = "Enter Book Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(bookquantity);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(bookprice);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(publicationname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(authorname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(bookname);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 493);
            panel2.Name = "panel2";
            panel2.Size = new Size(1735, 342);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Bahnschrift", 14F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1044, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(424, 41);
            dateTimePicker1.TabIndex = 21;
            // 
            // button3
            // 
            button3.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1533, 87);
            button3.Name = "button3";
            button3.Size = new Size(158, 143);
            button3.TabIndex = 20;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // bookquantity
            // 
            bookquantity.Font = new Font("Bahnschrift", 14F);
            bookquantity.Location = new Point(1044, 193);
            bookquantity.Name = "bookquantity";
            bookquantity.Size = new Size(424, 41);
            bookquantity.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 14F);
            label9.Location = new Point(815, 196);
            label9.Name = "label9";
            label9.Size = new Size(119, 34);
            label9.TabIndex = 18;
            label9.Text = "Quantity";
            // 
            // bookprice
            // 
            bookprice.Font = new Font("Bahnschrift", 14F);
            bookprice.Location = new Point(1044, 140);
            bookprice.Name = "bookprice";
            bookprice.Size = new Size(424, 41);
            bookprice.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 14F);
            label8.Location = new Point(815, 143);
            label8.Name = "label8";
            label8.Size = new Size(79, 34);
            label8.TabIndex = 16;
            label8.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 14F);
            label7.Location = new Point(815, 94);
            label7.Name = "label7";
            label7.Size = new Size(199, 34);
            label7.TabIndex = 14;
            label7.Text = "Purchase Date";
            // 
            // publicationname
            // 
            publicationname.Font = new Font("Bahnschrift", 14F);
            publicationname.Location = new Point(316, 193);
            publicationname.Name = "publicationname";
            publicationname.Size = new Size(424, 41);
            publicationname.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 14F);
            label6.Location = new Point(50, 200);
            label6.Name = "label6";
            label6.Size = new Size(235, 34);
            label6.TabIndex = 12;
            label6.Text = "Publication Name";
            // 
            // authorname
            // 
            authorname.Font = new Font("Bahnschrift", 14F);
            authorname.Location = new Point(316, 140);
            authorname.Name = "authorname";
            authorname.Size = new Size(424, 41);
            authorname.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(224, 39);
            label3.TabIndex = 0;
            label3.Text = "Update Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 14F);
            label4.Location = new Point(50, 147);
            label4.Name = "label4";
            label4.Size = new Size(183, 34);
            label4.TabIndex = 10;
            label4.Text = "Author Name";
            // 
            // bookname
            // 
            bookname.Font = new Font("Bahnschrift", 14F);
            bookname.Location = new Point(316, 91);
            bookname.Name = "bookname";
            bookname.Size = new Size(424, 41);
            bookname.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 14F);
            label5.Location = new Point(50, 95);
            label5.Name = "label5";
            label5.Size = new Size(160, 34);
            label5.TabIndex = 8;
            label5.Text = "Book Name";
            // 
            // view_books
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 835);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "view_books";
            Text = "view_books";
            Load += view_books_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private TextBox bookquantity;
        private Label label9;
        private TextBox bookprice;
        private Label label8;
        private Label label7;
        private TextBox publicationname;
        private Label label6;
        private TextBox authorname;
        private Label label3;
        private Label label4;
        private TextBox bookname;
        private Label label5;
        private Label label10;
        private Button button3;
        private DateTimePicker dateTimePicker1;
    }
}