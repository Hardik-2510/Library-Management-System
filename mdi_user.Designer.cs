namespace Library_Management_System
{
    partial class mdi_user
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(1053, 37);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBooksToolStripMenuItem, viewBooksToolStripMenuItem, issueBooksToolStripMenuItem, returnBookToolStripMenuItem });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(77, 29);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(270, 34);
            addNewBooksToolStripMenuItem.Text = "Add Books";
            addNewBooksToolStripMenuItem.Click += addNewBooksToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(270, 34);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(270, 34);
            issueBooksToolStripMenuItem.Text = "Issue Books";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(89, 29);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(217, 34);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentToolStripMenuItem
            // 
            viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            viewStudentToolStripMenuItem.Size = new Size(217, 34);
            viewStudentToolStripMenuItem.Text = "View Student";
            viewStudentToolStripMenuItem.Click += viewStudentToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 839);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 23, 0);
            statusStrip.Size = new Size(1053, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(60, 25);
            toolStripStatusLabel.Text = "Status";
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(270, 34);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // mdi_user
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 871);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "mdi_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to HackyBoy Learning Center";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
    }
}



