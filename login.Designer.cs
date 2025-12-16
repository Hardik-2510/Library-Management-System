namespace Library_Management_System
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            panel1 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 468);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(636, 349);
            button1.Name = "button1";
            button1.Size = new Size(163, 68);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 18F);
            textBox2.Location = new Point(702, 262);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(390, 49);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 18F);
            textBox1.Location = new Point(702, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 49);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 32F);
            label3.Location = new Point(474, 56);
            label3.Name = "label3";
            label3.Size = new Size(206, 75);
            label3.TabIndex = 3;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F);
            label2.Location = new Point(454, 265);
            label2.Name = "label2";
            label2.Size = new Size(193, 42);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F);
            label1.Location = new Point(454, 173);
            label1.Name = "label1";
            label1.Size = new Size(198, 42);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 361);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1131, 472);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "login_form";
            Text = "Login Form";
            Load += login_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        //private Button button1;
        private Label label3;
        private Button button1;
    }
}
