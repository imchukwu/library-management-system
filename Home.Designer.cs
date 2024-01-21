namespace lms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHomeScreen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLibrarian = new System.Windows.Forms.Button();
            this.btnBorrowing = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblHomeScreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 135);
            this.panel1.TabIndex = 0;
            // 
            // lblHomeScreen
            // 
            this.lblHomeScreen.AutoSize = true;
            this.lblHomeScreen.Font = new System.Drawing.Font("Microsoft YaHei", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeScreen.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHomeScreen.Location = new System.Drawing.Point(40, 34);
            this.lblHomeScreen.Name = "lblHomeScreen";
            this.lblHomeScreen.Size = new System.Drawing.Size(843, 75);
            this.lblHomeScreen.TabIndex = 0;
            this.lblHomeScreen.Text = "Library Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btnLibrarian);
            this.panel2.Controls.Add(this.btnBorrowing);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Controls.Add(this.btnStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 609);
            this.panel2.TabIndex = 1;
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLibrarian.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLibrarian.Location = new System.Drawing.Point(13, 181);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Size = new System.Drawing.Size(174, 43);
            this.btnLibrarian.TabIndex = 6;
            this.btnLibrarian.Text = "Librarian";
            this.btnLibrarian.UseVisualStyleBackColor = false;
            this.btnLibrarian.Click += new System.EventHandler(this.btnLibrarian_Click);
            // 
            // btnBorrowing
            // 
            this.btnBorrowing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrowing.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrowing.Location = new System.Drawing.Point(13, 132);
            this.btnBorrowing.Name = "btnBorrowing";
            this.btnBorrowing.Size = new System.Drawing.Size(174, 43);
            this.btnBorrowing.TabIndex = 5;
            this.btnBorrowing.Text = "Borrowing";
            this.btnBorrowing.UseVisualStyleBackColor = false;
            this.btnBorrowing.Click += new System.EventHandler(this.btnBorrowing_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(13, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBook.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBook.Location = new System.Drawing.Point(13, 83);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(174, 43);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStudent.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStudent.Location = new System.Drawing.Point(13, 34);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(174, 43);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHomeScreen;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.Button btnBorrowing;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBook;
    }
}

