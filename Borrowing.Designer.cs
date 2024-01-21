namespace lms
{
    partial class Borrowing
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
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.gBoxBooks = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtDateBorrowed = new System.Windows.Forms.TextBox();
            this.txtDateReturned = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookF = new System.Windows.Forms.Label();
            this.lblDateBorrowed = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.gBoxBooks.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(2, 409);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 62;
            this.dataGridViewBook.RowTemplate.Height = 28;
            this.dataGridViewBook.Size = new System.Drawing.Size(1276, 294);
            this.dataGridViewBook.TabIndex = 10;
            // 
            // gBoxBooks
            // 
            this.gBoxBooks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gBoxBooks.Controls.Add(this.lblName);
            this.gBoxBooks.Controls.Add(this.txtName);
            this.gBoxBooks.Controls.Add(this.btnDisplay);
            this.gBoxBooks.Controls.Add(this.btnUpdate);
            this.gBoxBooks.Controls.Add(this.btnDelete);
            this.gBoxBooks.Controls.Add(this.btnSave);
            this.gBoxBooks.Controls.Add(this.txtBook);
            this.gBoxBooks.Controls.Add(this.txtDateBorrowed);
            this.gBoxBooks.Controls.Add(this.txtDateReturned);
            this.gBoxBooks.Controls.Add(this.txtBookId);
            this.gBoxBooks.Controls.Add(this.lblBookF);
            this.gBoxBooks.Controls.Add(this.lblDateBorrowed);
            this.gBoxBooks.Controls.Add(this.lblDateReturned);
            this.gBoxBooks.Controls.Add(this.lblId);
            this.gBoxBooks.Location = new System.Drawing.Point(2, 132);
            this.gBoxBooks.Name = "gBoxBooks";
            this.gBoxBooks.Size = new System.Drawing.Size(1276, 319);
            this.gBoxBooks.TabIndex = 9;
            this.gBoxBooks.TabStop = false;
            this.gBoxBooks.Text = "Lend Books";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 29);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Student Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(236, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(439, 33);
            this.txtName.TabIndex = 20;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDisplay.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisplay.Location = new System.Drawing.Point(752, 201);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(117, 43);
            this.btnDisplay.TabIndex = 19;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(752, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 43);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(752, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 43);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(752, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBook
            // 
            this.txtBook.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook.Location = new System.Drawing.Point(236, 136);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(439, 33);
            this.txtBook.TabIndex = 13;
            // 
            // txtDateBorrowed
            // 
            this.txtDateBorrowed.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateBorrowed.Location = new System.Drawing.Point(236, 175);
            this.txtDateBorrowed.Name = "txtDateBorrowed";
            this.txtDateBorrowed.Size = new System.Drawing.Size(439, 33);
            this.txtDateBorrowed.TabIndex = 11;
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateReturned.Location = new System.Drawing.Point(236, 215);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.Size = new System.Drawing.Size(439, 33);
            this.txtDateReturned.TabIndex = 10;
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(236, 53);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(439, 33);
            this.txtBookId.TabIndex = 9;
            // 
            // lblBookF
            // 
            this.lblBookF.AutoSize = true;
            this.lblBookF.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookF.Location = new System.Drawing.Point(22, 136);
            this.lblBookF.Name = "lblBookF";
            this.lblBookF.Size = new System.Drawing.Size(75, 29);
            this.lblBookF.TabIndex = 8;
            this.lblBookF.Text = "Book:";
            // 
            // lblDateBorrowed
            // 
            this.lblDateBorrowed.AutoSize = true;
            this.lblDateBorrowed.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBorrowed.Location = new System.Drawing.Point(22, 176);
            this.lblDateBorrowed.Name = "lblDateBorrowed";
            this.lblDateBorrowed.Size = new System.Drawing.Size(188, 29);
            this.lblDateBorrowed.TabIndex = 7;
            this.lblDateBorrowed.Text = "Date Borrowed:";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(22, 215);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(184, 29);
            this.lblDateReturned.TabIndex = 6;
            this.lblDateReturned.Text = "Date Returned:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(22, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 29);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblLend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 135);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblLend
            // 
            this.lblLend.AutoSize = true;
            this.lblLend.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLend.Location = new System.Drawing.Point(511, 47);
            this.lblLend.Name = "lblLend";
            this.lblLend.Size = new System.Drawing.Size(282, 58);
            this.lblLend.TabIndex = 0;
            this.lblLend.Text = "Lend Books";
            // 
            // Borrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 694);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.gBoxBooks);
            this.Controls.Add(this.panel1);
            this.Name = "Borrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.gBoxBooks.ResumeLayout(false);
            this.gBoxBooks.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.GroupBox gBoxBooks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtDateBorrowed;
        private System.Windows.Forms.TextBox txtDateReturned;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookF;
        private System.Windows.Forms.Label lblDateBorrowed;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLend;
    }
}