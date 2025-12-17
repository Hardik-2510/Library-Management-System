namespace Library_Management_System
{
    partial class add_books
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox1.Location = new Point(277, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 35);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 1;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(16, 81);
            label2.Name = "label2";
            label2.Size = new Size(228, 28);
            label2.TabIndex = 3;
            label2.Text = "Book Author Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox2.Location = new Point(277, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 35);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(16, 140);
            label3.Name = "label3";
            label3.Size = new Size(207, 28);
            label3.TabIndex = 5;
            label3.Text = "Book Publication";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox3.Location = new Point(277, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 35);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(16, 207);
            label4.Name = "label4";
            label4.Size = new Size(247, 28);
            label4.TabIndex = 7;
            label4.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(16, 271);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 9;
            label5.Text = "Book Price";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox5.Location = new Point(277, 268);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(322, 35);
            textBox5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.Location = new Point(16, 340);
            label6.Name = "label6";
            label6.Size = new Size(174, 28);
            label6.TabIndex = 11;
            label6.Text = "Book Quantity";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox6.Location = new Point(277, 337);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(322, 35);
            textBox6.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(277, 411);
            button1.Name = "button1";
            button1.Size = new Size(129, 48);
            button1.TabIndex = 12;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(277, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 35);
            dateTimePicker1.TabIndex = 13;
            // 
            // add_books
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 477);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "add_books";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Books";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}